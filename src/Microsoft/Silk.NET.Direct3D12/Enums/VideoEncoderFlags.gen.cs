// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_FLAGS")]
    public enum VideoEncoderFlags : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FLAG_NONE")]
        VideoEncoderFlagNone = 0x0,
    }
}
