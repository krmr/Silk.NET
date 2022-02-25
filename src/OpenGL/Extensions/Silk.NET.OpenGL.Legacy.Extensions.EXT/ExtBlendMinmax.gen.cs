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
    [Extension("EXT_blend_minmax")]
    public unsafe partial class ExtBlendMinmax : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_blend_minmax";
        [NativeApi(EntryPoint = "glBlendEquationEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendEquation([Flow(FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glBlendEquationEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendEquation([Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        public ExtBlendMinmax(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

