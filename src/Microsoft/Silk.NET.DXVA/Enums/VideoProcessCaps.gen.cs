// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVA_VideoProcessCaps")]
    public enum VideoProcessCaps : int
    {
        [NativeName("Name", "DXVA_VideoProcess_None")]
        VideoProcessNone = 0x0,
        [NativeName("Name", "DXVA_VideoProcess_YUV2RGB")]
        VideoProcessYuv2Rgb = 0x1,
        [NativeName("Name", "DXVA_VideoProcess_StretchX")]
        VideoProcessStretchX = 0x2,
        [NativeName("Name", "DXVA_VideoProcess_StretchY")]
        VideoProcessStretchY = 0x4,
        [NativeName("Name", "DXVA_VideoProcess_AlphaBlend")]
        VideoProcessAlphaBlend = 0x8,
        [NativeName("Name", "DXVA_VideoProcess_SubRects")]
        VideoProcessSubRects = 0x10,
        [NativeName("Name", "DXVA_VideoProcess_SubStreams")]
        VideoProcessSubStreams = 0x20,
        [NativeName("Name", "DXVA_VideoProcess_SubStreamsExtended")]
        VideoProcessSubStreamsExtended = 0x40,
        [NativeName("Name", "DXVA_VideoProcess_YUV2RGBExtended")]
        VideoProcessYuv2Rgbextended = 0x80,
        [NativeName("Name", "DXVA_VideoProcess_AlphaBlendExtended")]
        VideoProcessAlphaBlendExtended = 0x100,
    }
}
