// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [Flags]
    [NativeName("Name", "StdVideoH264DisableDeblockingFilterIdc")]
    public enum StdVideoH264DisableDeblockingFilterIdc : int
    {
        [NativeName("Name", "STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_DISABLED")]
        StdVideoH264DisableDeblockingFilterIdcDisabled = 0x0,
        [NativeName("Name", "STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_ENABLED")]
        StdVideoH264DisableDeblockingFilterIdcEnabled = 0x1,
        [NativeName("Name", "STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_PARTIAL")]
        StdVideoH264DisableDeblockingFilterIdcPartial = 0x2,
        [NativeName("Name", "STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_INVALID")]
        StdVideoH264DisableDeblockingFilterIdcInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_MAX_ENUM")]
        StdVideoH264DisableDeblockingFilterIdcMaxEnum = 0x7FFFFFFF,
    }
}
