// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_CPU_PAGE_PROPERTY")]
    public enum CpuPageProperty : int
    {
        [NativeName("Name", "D3D12_CPU_PAGE_PROPERTY_UNKNOWN")]
        CpuPagePropertyUnknown = 0x0,
        [NativeName("Name", "D3D12_CPU_PAGE_PROPERTY_NOT_AVAILABLE")]
        CpuPagePropertyNotAvailable = 0x1,
        [NativeName("Name", "D3D12_CPU_PAGE_PROPERTY_WRITE_COMBINE")]
        CpuPagePropertyWriteCombine = 0x2,
        [NativeName("Name", "D3D12_CPU_PAGE_PROPERTY_WRITE_BACK")]
        CpuPagePropertyWriteBack = 0x3,
    }
}
