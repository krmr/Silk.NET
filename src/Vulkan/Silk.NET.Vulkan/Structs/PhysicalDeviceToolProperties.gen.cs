// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceToolProperties")]
    [NativeName("Aliases", "VkPhysicalDeviceToolPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceToolProperties : IChainable
    {
        public PhysicalDeviceToolProperties
        (
            StructureType? sType = StructureType.PhysicalDeviceToolProperties,
            void* pNext = null,
            ToolPurposeFlags? purposes = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (purposes is not null)
            {
                Purposes = purposes.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "name")]
        public fixed byte Name[256];
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "version")]
        public fixed byte Version[256];
/// <summary></summary>
        [NativeName("Type", "VkToolPurposeFlags")]
        [NativeName("Type.Name", "VkToolPurposeFlags")]
        [NativeName("Name", "purposes")]
        public ToolPurposeFlags Purposes;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "description")]
        public fixed byte Description[256];
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "layer")]
        public fixed byte Layer[256];

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceToolProperties;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
