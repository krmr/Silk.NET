// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE")]
    public enum VideoProcessorStereoFlipMode : int
    {
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FLIP_NONE")]
        VideoProcessorStereoFlipNone = 0x0,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FLIP_FRAME0")]
        VideoProcessorStereoFlipFrame0 = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FLIP_FRAME1")]
        VideoProcessorStereoFlipFrame1 = 0x2,
    }
}
