// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS")]
    public enum GpuBasedValidationPipelineStateCreateFlags : int
    {
        [NativeName("Name", "D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAG_NONE")]
        GpuBasedValidationPipelineStateCreateFlagNone = 0x0,
        [NativeName("Name", "D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAG_FRONT_LOAD_CREATE_TRACKING_ONLY_SHADERS")]
        GpuBasedValidationPipelineStateCreateFlagFrontLoadCreateTrackingOnlyShaders = 0x1,
        [NativeName("Name", "D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAG_FRONT_LOAD_CREATE_UNGUARDED_VALIDATION_SHADERS")]
        GpuBasedValidationPipelineStateCreateFlagFrontLoadCreateUnguardedValidationShaders = 0x2,
        [NativeName("Name", "D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAG_FRONT_LOAD_CREATE_GUARDED_VALIDATION_SHADERS")]
        GpuBasedValidationPipelineStateCreateFlagFrontLoadCreateGuardedValidationShaders = 0x4,
        [NativeName("Name", "D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS_VALID_MASK")]
        GpuBasedValidationPipelineStateCreateFlagsValidMask = 0x7,
    }
}
