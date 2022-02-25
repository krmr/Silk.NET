// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_INPUT_CLASSIFICATION")]
    public enum InputClassification : int
    {
        [NativeName("Name", "D3D12_INPUT_CLASSIFICATION_PER_VERTEX_DATA")]
        InputClassificationPerVertexData = 0x0,
        [NativeName("Name", "D3D12_INPUT_CLASSIFICATION_PER_INSTANCE_DATA")]
        InputClassificationPerInstanceData = 0x1,
    }
}
