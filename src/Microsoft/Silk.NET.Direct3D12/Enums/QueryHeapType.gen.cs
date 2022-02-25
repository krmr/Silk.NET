// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_QUERY_HEAP_TYPE")]
    public enum QueryHeapType : int
    {
        [NativeName("Name", "D3D12_QUERY_HEAP_TYPE_OCCLUSION")]
        QueryHeapTypeOcclusion = 0x0,
        [NativeName("Name", "D3D12_QUERY_HEAP_TYPE_TIMESTAMP")]
        QueryHeapTypeTimestamp = 0x1,
        [NativeName("Name", "D3D12_QUERY_HEAP_TYPE_PIPELINE_STATISTICS")]
        QueryHeapTypePipelineStatistics = 0x2,
        [NativeName("Name", "D3D12_QUERY_HEAP_TYPE_SO_STATISTICS")]
        QueryHeapTypeSOStatistics = 0x3,
        [NativeName("Name", "D3D12_QUERY_HEAP_TYPE_VIDEO_DECODE_STATISTICS")]
        QueryHeapTypeVideoDecodeStatistics = 0x4,
        [NativeName("Name", "D3D12_QUERY_HEAP_TYPE_COPY_QUEUE_TIMESTAMP")]
        QueryHeapTypeCopyQueueTimestamp = 0x5,
        [NativeName("Name", "D3D12_QUERY_HEAP_TYPE_PIPELINE_STATISTICS1")]
        QueryHeapTypePipelineStatistics1 = 0x7,
    }
}
