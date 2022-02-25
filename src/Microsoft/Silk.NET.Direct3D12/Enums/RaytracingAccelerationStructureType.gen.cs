// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE")]
    public enum RaytracingAccelerationStructureType : int
    {
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL")]
        RaytracingAccelerationStructureTypeTopLevel = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL")]
        RaytracingAccelerationStructureTypeBottomLevel = 0x1,
    }
}
