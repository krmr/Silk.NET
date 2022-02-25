using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Silk.NET.Core;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using Unsafe = System.Runtime.CompilerServices.Unsafe;

namespace Silk.NET.Vulkan
{
    public partial class Vk
    {
        private Instance? _currentInstance;
        private Device? _currentDevice;
        // TODO: 3.0 remove this
        private ConcurrentDictionary<(Instance?, Device?), IVTable> _vTables = new();
        public Instance? CurrentInstance
        {
            get => _currentInstance;
            set => SwapVTable(_vTables.GetOrAdd((_currentInstance = value, _currentDevice), _ => CreateVTable()));
        }
        public Device? CurrentDevice
        {
            get => _currentDevice;
            set
            {
                // if _currentDevice is null, chances are the user is telling us that they've made a device and want to
                // use it for loading, rather than *just* using the instance. given the function pointers are the same
                // for instance functions with or without a device, we should reuse the instance VTable rather than have
                // to reload all those functions again. 
                var createNew = _currentDevice is not null;
                SwapVTable
                (
                    _vTables.GetOrAdd
                    (
                        (_currentInstance, _currentDevice = value),
                        _ => createNew ? CreateVTable() : CurrentVTable.Clone()
                    )
                );
            }
        }

        public static Version32 Version10 => new Version32(1, 0, 0);
        public static Version32 Version11 => new Version32(1, 1, 0);
        public static Version32 Version12 => new Version32(1, 2, 0);
        public static Version32 Version13 => new Version32(1, 3, 0);

        public static Version32 MakeVersion
            (uint major, uint minor, uint patch = 0) => new Version32(major, minor, patch);
        

        public static Vk GetApi()
        {
            var ctx = new MultiNativeContext
                (CreateDefaultContext(new VulkanLibraryNameContainer().GetLibraryName()), null);
            var ret = new Vk(ctx);
            ctx.Contexts[1] = new LamdaNativeContext
            (
                x =>
                {
                    if (x.EndsWith("ProcAddr"))
                    {
                        return default;
                    }

                    nint ptr = default;
                    ptr = ret.GetDeviceProcAddr(ret.CurrentDevice.GetValueOrDefault(), x);
                    if (ptr != default)
                    {
                        return ptr;
                    }

                    ptr = ret.GetInstanceProcAddr(ret.CurrentInstance.GetValueOrDefault(), x);
                    return ptr;
                }
            );
            return ret;
        }

        public static Vk GetApi(InstanceCreateInfo info, out Instance instance) => GetApi(ref info, out instance);

        public static unsafe Vk GetApi(ref InstanceCreateInfo info, out Instance instance)
        {
            var ret = GetApi();
            ret.CreateInstance(in info, null, out instance);
            return ret;
        }

        public static Vk GetApi(ref InstanceCreateInfo info, ref AllocationCallbacks callbacks, out Instance instance)
        {
            var ret = GetApi();
            ret.CreateInstance(in info, in callbacks, out instance);
            return ret;
        }

        protected override void PostInit()
        {
            _vTables.TryAdd(default, CurrentVTable);
        }

        /// <summary>
        /// Attempts to load the given instance extension.
        /// </summary>
        /// <param name="instance">The instance to load the extension from.</param>
        /// <param name="ext">The loaded instance extension, or null if load failed.</param>
        /// <typeparam name="T">The instance extension to load.</typeparam>
        /// <remarks>
        /// This function doesn't check that the extension is enabled - you will get an error later on if you attempt
        /// to call an extension function from an extension that isn't loaded.
        /// </remarks>
        /// <returns>Whether the extension is available and loaded.</returns>
        public bool TryGetInstanceExtension<T>(Instance instance, out T ext) where T : NativeExtension<Vk> =>
            !((ext = IsInstanceExtensionPresent(ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                ? (T) Activator.CreateInstance
                (typeof(T), new LamdaNativeContext(x => GetInstanceProcAddr(instance, x)))
                : null) is null);

        /// <summary>
        /// Attempts to load the given device extension.
        /// </summary>
        /// <param name="instance">The instance to load the extension from.</param>
        /// <param name="device">The device to load the extension from.</param>
        /// <param name="ext">The loaded device extension, or null if load failed.</param>
        /// <typeparam name="T">The device extension to load.</typeparam>
        /// <remarks>
        /// This function doesn't check that the extension is enabled - you will get an error later on if you attempt
        /// to call an extension function from an extension that isn't loaded.
        /// </remarks>
        /// <returns>Whether the extension is available and loaded.</returns>
        public bool TryGetDeviceExtension<T>
            (Instance instance, Device device, out T ext) where T : NativeExtension<Vk> =>
            !((ext = IsDeviceExtensionPresent(instance, ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                ? (T) Activator.CreateInstance
                    (typeof(T), new LamdaNativeContext(x => GetDeviceProcAddr(device, x)))
                : null) is null);

        /// <inheritdoc />
        [Obsolete("Use IsInstanceExtensionPresent instead.", true)]
        public override bool IsExtensionPresent(string extension) => IsInstanceExtensionPresent(extension);

        private HashSet<string> _cachedInstanceExtensions;

        // Contains strings in form of '<IntPtr>|<Extension name>' for each extension and '<IntPtr>' to indicate an extension has been loaded.
        private HashSet<string> _cachedDeviceExtensions = new HashSet<string>();
        private ReaderWriterLockSlim _cachedDeviceExtensionsLock = new ReaderWriterLockSlim();

        private ConcurrentDictionary<Instance, PhysicalDevice[]> _cachedPhyscialDevices = new ConcurrentDictionary<Instance, PhysicalDevice[]>();

        /// <summary>
        /// Checks whether the given instance extension is available.
        /// </summary>
        /// <param name="extension">The instance extension name.</param>
        /// <returns>Whether the instance extension is available.</returns>
        public unsafe bool IsInstanceExtensionPresent(string extension)
        {
            // Note we use optimistic code to avoid locks, if this is called on multiple threads
            // then multiple initialisations can happen, only one thread will succeed in initialising the cache though.
            var cachedInstanceExtensions = _cachedInstanceExtensions;
            if (cachedInstanceExtensions is null)
            {
                // Get count of properties
                var instanceExtPropertiesCount = 0u;
                EnumerateInstanceExtensionProperties((byte*) 0, &instanceExtPropertiesCount, null);

                // Initialise return structure
                using var mem = GlobalMemory.Allocate((int) instanceExtPropertiesCount * sizeof(ExtensionProperties));
                var props = (ExtensionProperties*) Unsafe.AsPointer(ref mem.GetPinnableReference());

                // Get properties
                EnumerateInstanceExtensionProperties((byte*) 0, &instanceExtPropertiesCount, props);

                cachedInstanceExtensions = new HashSet<string>();
                for (var p = 0; p < instanceExtPropertiesCount; p++)
                {
                    cachedInstanceExtensions.Add(Marshal.PtrToStringAnsi((nint) props[p].ExtensionName));
                }

                // Thread-safe, only one initialisation will actually succeed.
                cachedInstanceExtensions = Interlocked.CompareExchange(ref _cachedInstanceExtensions, cachedInstanceExtensions, null) ??
                                           cachedInstanceExtensions;
            }

            return cachedInstanceExtensions.Contains(extension);
        }

        /// <summary>
        /// Checks whether the given device extension is available on any physical devices.
        /// </summary>
        /// <param name="instance">The Vulkan instance.</param>
        /// <param name="extension">The extension to check for.</param>
        /// <returns>Whether the device extension is available.</returns>
        public bool IsDeviceExtensionPresent(Instance instance, string extension)
            => IsDeviceExtensionPresent(instance, extension, out _);

        /// <summary>
        /// Checks whether the given device extension is available on the given physical device.
        /// </summary>
        /// <param name="device">The physical device.</param>
        /// <param name="extension">The extension to check for.</param>
        /// <returns>Whether the device extension is available.</returns>
        public unsafe bool IsDeviceExtensionPresent(PhysicalDevice device, string extension)
        {
            var prefix = device.Handle.ToString();
            var prefix_sep = prefix + '|';
            var fullKey = prefix_sep + extension;
            var result = false;

            // We place a devices handle into the hashset to indicate it has been previously loaded.
            // We then prefix entries with '<Handle>|' which will never collide with '<Handle>' (which is an
            // integer and so doesn't contain the pipe char '|').  This prevents doing two lookups, on cache hit and so
            // is twice as fast as using a Dictionary<string, HashSet<string>> in best case (and significantly faster than
            // Dictionary<string, List<string>>))
            // 
            // Note we use an upgradeable read lock, which is very fast.  We avoid a try...finally block on read
            // as the operations are inheritently safe, the additional try...finally on write is mitigated
            // as we also use it to dispose the memory allocation safely.  This gives us thread-safety at
            // no real additional cost.
            _cachedDeviceExtensionsLock.EnterUpgradeableReadLock();

            // We check for the extension first to avoid 2 lookups
            if (_cachedDeviceExtensions.Contains(fullKey))
            {
                // We found the extension
                result = true;
            }
            else if (!_cachedDeviceExtensions.Contains(prefix))
            {
                // The lack of the device handle indicates we've not been previously initialised.  We now need a write lock.
                _cachedDeviceExtensionsLock.EnterWriteLock();
                GlobalMemory mem = null;
                try
                {
                    var deviceExtPropertiesCount = 0u;

                    // Get number of properties
                    EnumerateDeviceExtensionProperties(device, (byte*) 0, &deviceExtPropertiesCount, null);

                    // Initialise return structure
                    mem = GlobalMemory.Allocate((int) deviceExtPropertiesCount * sizeof(ExtensionProperties));
                    var props = (ExtensionProperties*) Unsafe.AsPointer(ref mem.GetPinnableReference());

                    // Get properties
                    EnumerateDeviceExtensionProperties(device, (byte*) 0, &deviceExtPropertiesCount, props);
                    for (int j = 0; j < deviceExtPropertiesCount; j++)
                    {
                        // Prefix the extension name
                        var newKey = prefix_sep + Marshal.PtrToStringAnsi((nint) props[j].ExtensionName);
                        _cachedDeviceExtensions.Add(newKey);
                        if (!result && string.Equals(newKey, fullKey))
                        {
                            // We found the extension (no need to do another lookup as we're scanning anyway)
                            // As such this has taken 2 lookups + initialisation scan.
                            result = true;
                        }
                    }
                }
                finally
                {
                    _cachedDeviceExtensionsLock.ExitWriteLock();
                    mem?.Dispose();
                }
            } // else result = false - takes 2 lookups, one to check for extension, and one to check initialisation.

            _cachedDeviceExtensionsLock.ExitUpgradeableReadLock();
            return result;
        }

        /// <summary>
        /// Checks whether the given device extension is available, and returns the first physical device that provides
        /// it.
        /// </summary>
        /// <param name="instance">The Vulkan instance to use.</param>
        /// <param name="extension">The extension to check for.</param>
        /// <param name="device">The first physical device that provides the extension.</param>
        /// <returns>Whether the device extension is available.</returns>
        public unsafe bool IsDeviceExtensionPresent(Instance instance, string extension, out PhysicalDevice device)
        {
            device = GetPhysicalDevices(instance).FirstOrDefault(pd => IsDeviceExtensionPresent(pd, extension));
            return device.Handle != 0;
        }

        /// <summary>
        /// Gets all the physical devices for the instance.
        /// </summary>
        /// <param name="instance">The Vulkan instance to use.</param>
        /// <returns>Whether the device extension is available.</returns>
        public unsafe IReadOnlyCollection<PhysicalDevice> GetPhysicalDevices(Instance instance)
        {
            return _cachedPhyscialDevices.GetOrAdd(instance, i =>
            {
                var physicalDeviceCount = 0u;
                EnumeratePhysicalDevices(i, &physicalDeviceCount, null);

                // Initialise return structure
                if (physicalDeviceCount < 1)
                    return Array.Empty<PhysicalDevice>();

                var physicalDevices = new PhysicalDevice[physicalDeviceCount];
                fixed (PhysicalDevice* pdp = physicalDevices)
                {
                    EnumeratePhysicalDevices(instance, &physicalDeviceCount, pdp);
                }
                return physicalDevices;
            });
        }

        /// <summary>
        /// Creates a new <see cref="Vk"/> object that reuses the instance functions already collected by this
        /// instance for the given instance-device combination.
        /// </summary>
        /// <param name="instance">The instance to use for the created object.</param>
        /// <param name="device">The device to use for the created object.</param>
        /// <returns>The object.</returns>
        public Vk CloneWith(Instance instance, Device device)
        {
            var ret = GetApi();
            ret._vTables = _vTables;
            ret._cachedDeviceExtensionsLock = _cachedDeviceExtensionsLock;
            ret._cachedDeviceExtensions = _cachedDeviceExtensions;
            ret._cachedInstanceExtensions = _cachedInstanceExtensions;
            ret._cachedPhyscialDevices = _cachedPhyscialDevices;
            ret.CurrentInstance = instance;
            ret.CurrentDevice = device;
            return ret;
        }

        /// <summary>
        /// Clears all cached extension information, so that the next time extension-related functions are called the
        /// cached extension information is refreshed.
        /// </summary>
        public void PurgeExtensionCache()
        {
            _cachedInstanceExtensions.Clear();
            _cachedPhyscialDevices.Clear();
            _cachedDeviceExtensionsLock.EnterWriteLock();
            try
            {
                _cachedDeviceExtensions.Clear();
            }
            finally
            {
                _cachedDeviceExtensionsLock.ExitWriteLock();
            }
        }
    }
}
