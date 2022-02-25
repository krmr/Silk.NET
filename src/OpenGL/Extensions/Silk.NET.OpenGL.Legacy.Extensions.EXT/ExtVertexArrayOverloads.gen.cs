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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtVertexArrayOverloads
    {
        public static unsafe void EdgeFlagPointer(this ExtVertexArray thisApi, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "stride, count"), Flow(FlowDirection.In)] ReadOnlySpan<bool> pointer)
        {
            // SpanOverloader
            thisApi.EdgeFlagPointer(stride, count, in pointer.GetPinnableReference());
        }

        public static unsafe void EdgeFlagPointer(this ExtVertexArray thisApi, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "stride, count"), Flow(FlowDirection.In)] ReadOnlySpan<Boolean> pointer)
        {
            // SpanOverloader
            thisApi.EdgeFlagPointer(stride, count, in pointer.GetPinnableReference());
        }

    }
}

