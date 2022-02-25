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
    [NativeName("Name", "VkCommandBufferInheritanceRenderingInfoKHR")]
    [NativeName("AliasOf", "VkCommandBufferInheritanceRenderingInfo")]
    public unsafe partial struct CommandBufferInheritanceRenderingInfoKHR : IExtendsChain<CommandBufferInheritanceInfo>
    {
        public CommandBufferInheritanceRenderingInfoKHR
        (
            StructureType? sType = StructureType.CommandBufferInheritanceRenderingInfo,
            void* pNext = null,
            RenderingFlags? flags = null,
            uint? viewMask = null,
            uint? colorAttachmentCount = null,
            Format* pColorAttachmentFormats = null,
            Format? depthAttachmentFormat = null,
            Format? stencilAttachmentFormat = null,
            SampleCountFlags? rasterizationSamples = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (viewMask is not null)
            {
                ViewMask = viewMask.Value;
            }

            if (colorAttachmentCount is not null)
            {
                ColorAttachmentCount = colorAttachmentCount.Value;
            }

            if (pColorAttachmentFormats is not null)
            {
                PColorAttachmentFormats = pColorAttachmentFormats;
            }

            if (depthAttachmentFormat is not null)
            {
                DepthAttachmentFormat = depthAttachmentFormat.Value;
            }

            if (stencilAttachmentFormat is not null)
            {
                StencilAttachmentFormat = stencilAttachmentFormat.Value;
            }

            if (rasterizationSamples is not null)
            {
                RasterizationSamples = rasterizationSamples.Value;
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
        [NativeName("Type", "VkRenderingFlags")]
        [NativeName("Type.Name", "VkRenderingFlags")]
        [NativeName("Name", "flags")]
        public RenderingFlags Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "viewMask")]
        public uint ViewMask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "colorAttachmentCount")]
        public uint ColorAttachmentCount;
/// <summary></summary>
        [NativeName("Type", "VkFormat*")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "pColorAttachmentFormats")]
        public Format* PColorAttachmentFormats;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "depthAttachmentFormat")]
        public Format DepthAttachmentFormat;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "stencilAttachmentFormat")]
        public Format StencilAttachmentFormat;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlagBits")]
        [NativeName("Type.Name", "VkSampleCountFlagBits")]
        [NativeName("Name", "rasterizationSamples")]
        public SampleCountFlags RasterizationSamples;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CommandBufferInheritanceRenderingInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
