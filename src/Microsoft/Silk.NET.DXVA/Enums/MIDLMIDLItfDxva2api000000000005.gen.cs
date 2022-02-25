// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "__MIDL___MIDL_itf_dxva2api_0000_0000_0005")]
    public enum MIDLMIDLItfDxva2api000000000005 : int
    {
        [NativeName("Name", "DXVA2_NoiseFilterTech_Unsupported")]
        DXVA2NoiseFilterTechUnsupported = 0x0,
        [NativeName("Name", "DXVA2_NoiseFilterTech_Unknown")]
        DXVA2NoiseFilterTechUnknown = 0x1,
        [NativeName("Name", "DXVA2_NoiseFilterTech_Median")]
        DXVA2NoiseFilterTechMedian = 0x2,
        [NativeName("Name", "DXVA2_NoiseFilterTech_Temporal")]
        DXVA2NoiseFilterTechTemporal = 0x4,
        [NativeName("Name", "DXVA2_NoiseFilterTech_BlockNoise")]
        DXVA2NoiseFilterTechBlockNoise = 0x8,
        [NativeName("Name", "DXVA2_NoiseFilterTech_MosquitoNoise")]
        DXVA2NoiseFilterTechMosquitoNoise = 0x10,
        [NativeName("Name", "DXVA2_NoiseFilterTech_Mask")]
        DXVA2NoiseFilterTechMask = 0x1F,
    }
}
