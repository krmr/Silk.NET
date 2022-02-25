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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_texture_view")]
    public unsafe partial class ArbTextureView : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_texture_view";
        [NativeApi(EntryPoint = "glTextureView", Convention = CallingConvention.Winapi)]
        public partial void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        [NativeApi(EntryPoint = "glTextureView", Convention = CallingConvention.Winapi)]
        public partial void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        [NativeApi(EntryPoint = "glTextureView", Convention = CallingConvention.Winapi)]
        public partial void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        [NativeApi(EntryPoint = "glTextureView", Convention = CallingConvention.Winapi)]
        public partial void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        public ArbTextureView(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

