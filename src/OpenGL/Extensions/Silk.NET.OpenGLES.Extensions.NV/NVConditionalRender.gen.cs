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
    [Extension("NV_conditional_render")]
    public unsafe partial class NVConditionalRender : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_conditional_render";
        [NativeApi(EntryPoint = "glBeginConditionalRenderNV", Convention = CallingConvention.Winapi)]
        public partial void BeginConditionalRender([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV mode);

        [NativeApi(EntryPoint = "glBeginConditionalRenderNV", Convention = CallingConvention.Winapi)]
        public partial void BeginConditionalRender([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ConditionalRenderMode mode);

        [NativeApi(EntryPoint = "glEndConditionalRenderNV", Convention = CallingConvention.Winapi)]
        public partial void EndConditionalRender();

        public NVConditionalRender(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

