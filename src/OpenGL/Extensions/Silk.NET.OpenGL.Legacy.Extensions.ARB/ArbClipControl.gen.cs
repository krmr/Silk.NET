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
    [Extension("ARB_clip_control")]
    public unsafe partial class ArbClipControl : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_clip_control";
        [NativeApi(EntryPoint = "glClipControl", Convention = CallingConvention.Winapi)]
        public partial void ClipControl([Flow(FlowDirection.In)] ARB origin, [Flow(FlowDirection.In)] ARB depth);

        [NativeApi(EntryPoint = "glClipControl", Convention = CallingConvention.Winapi)]
        public partial void ClipControl([Flow(FlowDirection.In)] ARB origin, [Flow(FlowDirection.In)] ClipControlDepth depth);

        [NativeApi(EntryPoint = "glClipControl", Convention = CallingConvention.Winapi)]
        public partial void ClipControl([Flow(FlowDirection.In)] ClipControlOrigin origin, [Flow(FlowDirection.In)] ARB depth);

        [NativeApi(EntryPoint = "glClipControl", Convention = CallingConvention.Winapi)]
        public partial void ClipControl([Flow(FlowDirection.In)] ClipControlOrigin origin, [Flow(FlowDirection.In)] ClipControlDepth depth);

        public ArbClipControl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

