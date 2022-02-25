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
    [NativeName("Name", "VkMutableDescriptorTypeCreateInfoVALVE")]
    public unsafe partial struct MutableDescriptorTypeCreateInfoVALVE : IExtendsChain<DescriptorSetLayoutCreateInfo>, IExtendsChain<DescriptorPoolCreateInfo>
    {
        public MutableDescriptorTypeCreateInfoVALVE
        (
            StructureType? sType = StructureType.MutableDescriptorTypeCreateInfoValve,
            void* pNext = null,
            uint? mutableDescriptorTypeListCount = null,
            MutableDescriptorTypeListVALVE* pMutableDescriptorTypeLists = null
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

            if (mutableDescriptorTypeListCount is not null)
            {
                MutableDescriptorTypeListCount = mutableDescriptorTypeListCount.Value;
            }

            if (pMutableDescriptorTypeLists is not null)
            {
                PMutableDescriptorTypeLists = pMutableDescriptorTypeLists;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "mutableDescriptorTypeListCount")]
        public uint MutableDescriptorTypeListCount;
/// <summary></summary>
        [NativeName("Type", "VkMutableDescriptorTypeListVALVE*")]
        [NativeName("Type.Name", "VkMutableDescriptorTypeListVALVE")]
        [NativeName("Name", "pMutableDescriptorTypeLists")]
        public MutableDescriptorTypeListVALVE* PMutableDescriptorTypeLists;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.MutableDescriptorTypeCreateInfoValve;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
