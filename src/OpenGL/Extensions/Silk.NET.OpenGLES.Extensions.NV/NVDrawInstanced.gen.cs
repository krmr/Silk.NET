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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_draw_instanced")]
    public unsafe partial class NVDrawInstanced : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_draw_instanced";
        [NativeApi(EntryPoint = "glDrawArraysInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void DrawArraysInstanced([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawArraysInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void DrawArraysInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstanced([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] NV type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] NV type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstanced([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] NV type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] NV type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged;

        public NVDrawInstanced(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

