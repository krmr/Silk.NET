// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_TYPE")]
    public enum MetaCommandParameterType : int
    {
        [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_TYPE_FLOAT")]
        MetaCommandParameterTypeFloat = 0x0,
        [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_TYPE_UINT64")]
        MetaCommandParameterTypeUint64 = 0x1,
        [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_TYPE_GPU_VIRTUAL_ADDRESS")]
        MetaCommandParameterTypeGpuVirtualAddress = 0x2,
        [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_TYPE_CPU_DESCRIPTOR_HANDLE_HEAP_TYPE_CBV_SRV_UAV")]
        MetaCommandParameterTypeCpuDescriptorHandleHeapTypeCbvSrvUav = 0x3,
        [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_TYPE_GPU_DESCRIPTOR_HANDLE_HEAP_TYPE_CBV_SRV_UAV")]
        MetaCommandParameterTypeGpuDescriptorHandleHeapTypeCbvSrvUav = 0x4,
    }
}
