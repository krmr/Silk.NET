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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_conservative_raster_pre_snap_triangles")]
    public unsafe partial class NVConservativeRasterPreSnapTriangles : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_conservative_raster_pre_snap_triangles";
        [NativeApi(EntryPoint = "glConservativeRasterParameteriNV", Convention = CallingConvention.Winapi)]
        public partial void ConservativeRasterParameter([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int param);

        public NVConservativeRasterPreSnapTriangles(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

