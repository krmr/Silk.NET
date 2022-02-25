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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbGlSpirvOverloads
    {
        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] byte* pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, in pConstantValue.GetPinnableReference());
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] byte* pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, pEntryPoint, numSpecializationConstants, in pConstantIndex.GetPinnableReference(), pConstantValue);
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] byte* pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantIndex, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, pEntryPoint, numSpecializationConstants, in pConstantIndex.GetPinnableReference(), in pConstantValue.GetPinnableReference());
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, in pEntryPoint.GetPinnableReference(), numSpecializationConstants, pConstantIndex, pConstantValue);
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, in pEntryPoint.GetPinnableReference(), numSpecializationConstants, pConstantIndex, in pConstantValue.GetPinnableReference());
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, in pEntryPoint.GetPinnableReference(), numSpecializationConstants, in pConstantIndex.GetPinnableReference(), pConstantValue);
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantIndex, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, in pEntryPoint.GetPinnableReference(), numSpecializationConstants, in pConstantIndex.GetPinnableReference(), in pConstantValue.GetPinnableReference());
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, in pConstantValue.GetPinnableReference());
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, pEntryPoint, numSpecializationConstants, in pConstantIndex.GetPinnableReference(), pConstantValue);
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantIndex, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, pEntryPoint, numSpecializationConstants, in pConstantIndex.GetPinnableReference(), in pConstantValue.GetPinnableReference());
        }

    }
}

