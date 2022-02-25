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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_blend_func_extended")]
    public unsafe partial class ArbBlendFuncExtended : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_blend_func_extended";
        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed", Convention = CallingConvention.Winapi)]
        public partial void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed", Convention = CallingConvention.Winapi)]
        public partial void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetFragDataIndex", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetFragDataIndex", Convention = CallingConvention.Winapi)]
        public partial int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetFragDataIndex", Convention = CallingConvention.Winapi)]
        public partial int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        public ArbBlendFuncExtended(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

