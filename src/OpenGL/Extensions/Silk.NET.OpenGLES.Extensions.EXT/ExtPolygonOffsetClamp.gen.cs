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
    [Extension("EXT_polygon_offset_clamp")]
    public unsafe partial class ExtPolygonOffsetClamp : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_polygon_offset_clamp";
        [NativeApi(EntryPoint = "glPolygonOffsetClampEXT", Convention = CallingConvention.Winapi)]
        public partial void PolygonOffsetClamp([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units, [Flow(FlowDirection.In)] float clamp);

        public ExtPolygonOffsetClamp(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

