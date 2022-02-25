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
    [NativeName("Name", "VkDrmFormatModifierProperties2EXT")]
    public unsafe partial struct DrmFormatModifierProperties2EXT
    {
        public DrmFormatModifierProperties2EXT
        (
            ulong? drmFormatModifier = null,
            uint? drmFormatModifierPlaneCount = null,
            FormatFeatureFlags2? drmFormatModifierTilingFeatures = null
        ) : this()
        {
            if (drmFormatModifier is not null)
            {
                DrmFormatModifier = drmFormatModifier.Value;
            }

            if (drmFormatModifierPlaneCount is not null)
            {
                DrmFormatModifierPlaneCount = drmFormatModifierPlaneCount.Value;
            }

            if (drmFormatModifierTilingFeatures is not null)
            {
                DrmFormatModifierTilingFeatures = drmFormatModifierTilingFeatures.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "drmFormatModifier")]
        public ulong DrmFormatModifier;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "drmFormatModifierPlaneCount")]
        public uint DrmFormatModifierPlaneCount;
/// <summary></summary>
        [NativeName("Type", "VkFormatFeatureFlags2")]
        [NativeName("Type.Name", "VkFormatFeatureFlags2")]
        [NativeName("Name", "drmFormatModifierTilingFeatures")]
        public FormatFeatureFlags2 DrmFormatModifierTilingFeatures;
    }
}
