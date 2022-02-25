// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_TILE_MAPPING_FLAGS")]
    public enum TileMappingFlags : int
    {
        [NativeName("Name", "D3D12_TILE_MAPPING_FLAG_NONE")]
        TileMappingFlagNone = 0x0,
        [NativeName("Name", "D3D12_TILE_MAPPING_FLAG_NO_HAZARD")]
        TileMappingFlagNoHazard = 0x1,
    }
}
