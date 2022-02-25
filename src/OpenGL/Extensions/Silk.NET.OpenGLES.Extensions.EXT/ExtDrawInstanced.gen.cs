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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_draw_instanced")]
    public unsafe partial class ExtDrawInstanced : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_draw_instanced";
        [NativeApi(EntryPoint = "glDrawArraysInstancedEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawArraysInstanced([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] int start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawArraysInstancedEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawArraysInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstanced([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstanced([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glDrawElementsInstancedEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged;

        public ExtDrawInstanced(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

