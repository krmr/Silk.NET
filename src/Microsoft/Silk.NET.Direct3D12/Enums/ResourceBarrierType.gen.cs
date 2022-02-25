// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_RESOURCE_BARRIER_TYPE")]
    public enum ResourceBarrierType : int
    {
        [NativeName("Name", "D3D12_RESOURCE_BARRIER_TYPE_TRANSITION")]
        ResourceBarrierTypeTransition = 0x0,
        [NativeName("Name", "D3D12_RESOURCE_BARRIER_TYPE_ALIASING")]
        ResourceBarrierTypeAliasing = 0x1,
        [NativeName("Name", "D3D12_RESOURCE_BARRIER_TYPE_UAV")]
        ResourceBarrierTypeUav = 0x2,
    }
}
