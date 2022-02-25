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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public static class ArbVertexAttrib64bitOverloads
    {
        public static unsafe void GetVertexAttribL(this ArbVertexAttrib64bit thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribL(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribL(this ArbVertexAttrib64bit thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribL(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void VertexAttribL1(this ArbVertexAttrib64bit thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttribL1(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribL2(this ArbVertexAttrib64bit thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttribL2(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribL3(this ArbVertexAttrib64bit thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttribL3(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribL4(this ArbVertexAttrib64bit thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttribL4(index, in v.GetPinnableReference());
        }

    }
}

