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
    [NativeName("Name", "VkImageSparseMemoryRequirementsInfo2KHR")]
    [NativeName("AliasOf", "VkImageSparseMemoryRequirementsInfo2")]
    public unsafe partial struct ImageSparseMemoryRequirementsInfo2KHR : IChainable
    {
        public ImageSparseMemoryRequirementsInfo2KHR
        (
            StructureType? sType = StructureType.ImageSparseMemoryRequirementsInfo2,
            void* pNext = null,
            Image? image = null
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

            if (image is not null)
            {
                Image = image.Value;
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
        [NativeName("Type", "VkImage")]
        [NativeName("Type.Name", "VkImage")]
        [NativeName("Name", "image")]
        public Image Image;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImageSparseMemoryRequirementsInfo2;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
