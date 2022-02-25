// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_TYPE_H264")]
    public enum VideoEncoderFrameTypeH264 : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_TYPE_H264_I_FRAME")]
        VideoEncoderFrameTypeH264IFrame = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_TYPE_H264_P_FRAME")]
        VideoEncoderFrameTypeH264PFrame = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_TYPE_H264_B_FRAME")]
        VideoEncoderFrameTypeH264BFrame = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_TYPE_H264_IDR_FRAME")]
        VideoEncoderFrameTypeH264IdrFrame = 0x3,
    }
}
