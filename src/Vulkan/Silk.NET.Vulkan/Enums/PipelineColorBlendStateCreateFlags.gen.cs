// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPipelineColorBlendStateCreateFlags")]
    public enum PipelineColorBlendStateCreateFlags : int
    {
        [NativeName("Name", "VK_PIPELINE_COLOR_BLEND_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_BIT_ARM")]
        PipelineColorBlendStateCreateRasterizationOrderAttachmentAccessBitArm = 1,
    }
}
