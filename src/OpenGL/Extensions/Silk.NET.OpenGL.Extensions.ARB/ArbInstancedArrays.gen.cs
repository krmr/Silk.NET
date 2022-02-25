// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_instanced_arrays")]
    public unsafe partial class ArbInstancedArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_instanced_arrays";
        [NativeApi(EntryPoint = "glVertexAttribDivisorARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribDivisor([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint divisor);

        public ArbInstancedArrays(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

