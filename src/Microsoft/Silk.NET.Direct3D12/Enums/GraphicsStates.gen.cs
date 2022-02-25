// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_GRAPHICS_STATES")]
    public enum GraphicsStates : int
    {
        [NativeName("Name", "D3D12_GRAPHICS_STATE_NONE")]
        GraphicsStateNone = 0x0,
        [NativeName("Name", "D3D12_GRAPHICS_STATE_IA_VERTEX_BUFFERS")]
        GraphicsStateIAVertexBuffers = 0x1,
        [NativeName("Name", "D3D12_GRAPHICS_STATE_IA_INDEX_BUFFER")]
        GraphicsStateIAIndexBuffer = 0x2,
        [NativeName("Name", "D3D12_GRAPHICS_STATE_IA_PRIMITIVE_TOPOLOGY")]
        GraphicsStateIAPrimitiveTopology = 0x4,
        [NativeName("Name", "D3D12_GRAPHICS_STATE_DESCRIPTOR_HEAP")]
        GraphicsStateDescriptorHeap = 0x8,
        [NativeName("Name", "D3D12_GRAPHICS_STATE_GRAPHICS_ROOT_SIGNATURE")]
        GraphicsStateGraphicsRootSignature = 0x10,
        [NativeName("Name", "D3D12_GRAPHICS_STATE_COMPUTE_ROOT_SIGNATURE")]
        GraphicsStateComputeRootSignature = 0x20,
        [NativeName("Name", "D3D12_GRAPHICS_STATE_RS_VIEWPORTS")]
        GraphicsStateRSViewports = 0x40,
        [NativeName("Name", "D3D12_GRAPHICS_STATE_RS_SCISSOR_RECTS")]
        GraphicsStateRSScissorRects = 0x80,
        [NativeName("Name", "D3D12_GRAPHICS_STATE_PREDICATION")]
        GraphicsStatePredication = 0x100,
        [NativeName("Name", "D3D12_GRAPHICS_STATE_OM_RENDER_TARGETS")]
        GraphicsStateOMRenderTargets = 0x200,
        [NativeName("Name", "D3D12_GRAPHICS_STATE_OM_STENCIL_REF")]
        GraphicsStateOMStencilRef = 0x400,
        [NativeName("Name", "D3D12_GRAPHICS_STATE_OM_BLEND_FACTOR")]
        GraphicsStateOMBlendFactor = 0x800,
        [NativeName("Name", "D3D12_GRAPHICS_STATE_PIPELINE_STATE")]
        GraphicsStatePipelineState = 0x1000,
        [NativeName("Name", "D3D12_GRAPHICS_STATE_SO_TARGETS")]
        GraphicsStateSOTargets = 0x2000,
        [NativeName("Name", "D3D12_GRAPHICS_STATE_OM_DEPTH_BOUNDS")]
        GraphicsStateOMDepthBounds = 0x4000,
        [NativeName("Name", "D3D12_GRAPHICS_STATE_SAMPLE_POSITIONS")]
        GraphicsStateSamplePositions = 0x8000,
        [NativeName("Name", "D3D12_GRAPHICS_STATE_VIEW_INSTANCE_MASK")]
        GraphicsStateViewInstanceMask = 0x10000,
    }
}
