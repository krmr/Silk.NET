// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_OUTPUT_RATE")]
    public enum VideoProcessorOutputRate : int
    {
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_NORMAL")]
        VideoProcessorOutputRateNormal = 0x0,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_HALF")]
        VideoProcessorOutputRateHalf = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_CUSTOM")]
        VideoProcessorOutputRateCustom = 0x2,
    }
}
