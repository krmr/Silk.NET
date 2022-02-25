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
    [Extension("NV_clip_space_w_scaling")]
    public unsafe partial class NVClipSpaceWScaling : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_clip_space_w_scaling";
        [NativeApi(EntryPoint = "glViewportPositionWScaleNV", Convention = CallingConvention.Winapi)]
        public partial void ViewportPositionWScale([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float xcoeff, [Flow(FlowDirection.In)] float ycoeff);

        public NVClipSpaceWScaling(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

