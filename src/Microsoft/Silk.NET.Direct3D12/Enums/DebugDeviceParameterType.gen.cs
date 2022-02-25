// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_DEBUG_DEVICE_PARAMETER_TYPE")]
    public enum DebugDeviceParameterType : int
    {
        [NativeName("Name", "D3D12_DEBUG_DEVICE_PARAMETER_FEATURE_FLAGS")]
        DebugDeviceParameterFeatureFlags = 0x0,
        [NativeName("Name", "D3D12_DEBUG_DEVICE_PARAMETER_GPU_BASED_VALIDATION_SETTINGS")]
        DebugDeviceParameterGpuBasedValidationSettings = 0x1,
        [NativeName("Name", "D3D12_DEBUG_DEVICE_PARAMETER_GPU_SLOWDOWN_PERFORMANCE_FACTOR")]
        DebugDeviceParameterGpuSlowdownPerformanceFactor = 0x2,
    }
}
