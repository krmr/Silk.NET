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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_blend_equation_separate")]
    public unsafe partial class ExtBlendEquationSeparate : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_blend_equation_separate";
        [NativeApi(EntryPoint = "glBlendEquationSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] EXT modeRGB, [Flow(FlowDirection.In)] EXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] EXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] EXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        public ExtBlendEquationSeparate(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

