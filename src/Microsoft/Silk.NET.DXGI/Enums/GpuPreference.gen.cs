// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [Flags]
    [NativeName("Name", "DXGI_GPU_PREFERENCE")]
    public enum GpuPreference : int
    {
        [NativeName("Name", "DXGI_GPU_PREFERENCE_UNSPECIFIED")]
        GpuPreferenceUnspecified = 0x0,
        [NativeName("Name", "DXGI_GPU_PREFERENCE_MINIMUM_POWER")]
        GpuPreferenceMinimumPower = 0x1,
        [NativeName("Name", "DXGI_GPU_PREFERENCE_HIGH_PERFORMANCE")]
        GpuPreferenceHighPerformance = 0x2,
    }
}
