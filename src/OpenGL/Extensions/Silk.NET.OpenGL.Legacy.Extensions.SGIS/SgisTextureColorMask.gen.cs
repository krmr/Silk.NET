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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_texture_color_mask")]
    public unsafe partial class SgisTextureColorMask : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_texture_color_mask";
        [NativeApi(EntryPoint = "glTextureColorMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void TextureColorMask([Flow(FlowDirection.In)] bool red, [Flow(FlowDirection.In)] bool green, [Flow(FlowDirection.In)] bool blue, [Flow(FlowDirection.In)] bool alpha);

        [NativeApi(EntryPoint = "glTextureColorMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void TextureColorMask([Flow(FlowDirection.In)] bool red, [Flow(FlowDirection.In)] bool green, [Flow(FlowDirection.In)] bool blue, [Flow(FlowDirection.In)] Boolean alpha);

        [NativeApi(EntryPoint = "glTextureColorMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void TextureColorMask([Flow(FlowDirection.In)] bool red, [Flow(FlowDirection.In)] bool green, [Flow(FlowDirection.In)] Boolean blue, [Flow(FlowDirection.In)] bool alpha);

        [NativeApi(EntryPoint = "glTextureColorMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void TextureColorMask([Flow(FlowDirection.In)] bool red, [Flow(FlowDirection.In)] bool green, [Flow(FlowDirection.In)] Boolean blue, [Flow(FlowDirection.In)] Boolean alpha);

        [NativeApi(EntryPoint = "glTextureColorMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void TextureColorMask([Flow(FlowDirection.In)] bool red, [Flow(FlowDirection.In)] Boolean green, [Flow(FlowDirection.In)] bool blue, [Flow(FlowDirection.In)] bool alpha);

        [NativeApi(EntryPoint = "glTextureColorMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void TextureColorMask([Flow(FlowDirection.In)] bool red, [Flow(FlowDirection.In)] Boolean green, [Flow(FlowDirection.In)] bool blue, [Flow(FlowDirection.In)] Boolean alpha);

        [NativeApi(EntryPoint = "glTextureColorMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void TextureColorMask([Flow(FlowDirection.In)] bool red, [Flow(FlowDirection.In)] Boolean green, [Flow(FlowDirection.In)] Boolean blue, [Flow(FlowDirection.In)] bool alpha);

        [NativeApi(EntryPoint = "glTextureColorMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void TextureColorMask([Flow(FlowDirection.In)] bool red, [Flow(FlowDirection.In)] Boolean green, [Flow(FlowDirection.In)] Boolean blue, [Flow(FlowDirection.In)] Boolean alpha);

        [NativeApi(EntryPoint = "glTextureColorMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void TextureColorMask([Flow(FlowDirection.In)] Boolean red, [Flow(FlowDirection.In)] bool green, [Flow(FlowDirection.In)] bool blue, [Flow(FlowDirection.In)] bool alpha);

        [NativeApi(EntryPoint = "glTextureColorMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void TextureColorMask([Flow(FlowDirection.In)] Boolean red, [Flow(FlowDirection.In)] bool green, [Flow(FlowDirection.In)] bool blue, [Flow(FlowDirection.In)] Boolean alpha);

        [NativeApi(EntryPoint = "glTextureColorMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void TextureColorMask([Flow(FlowDirection.In)] Boolean red, [Flow(FlowDirection.In)] bool green, [Flow(FlowDirection.In)] Boolean blue, [Flow(FlowDirection.In)] bool alpha);

        [NativeApi(EntryPoint = "glTextureColorMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void TextureColorMask([Flow(FlowDirection.In)] Boolean red, [Flow(FlowDirection.In)] bool green, [Flow(FlowDirection.In)] Boolean blue, [Flow(FlowDirection.In)] Boolean alpha);

        [NativeApi(EntryPoint = "glTextureColorMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void TextureColorMask([Flow(FlowDirection.In)] Boolean red, [Flow(FlowDirection.In)] Boolean green, [Flow(FlowDirection.In)] bool blue, [Flow(FlowDirection.In)] bool alpha);

        [NativeApi(EntryPoint = "glTextureColorMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void TextureColorMask([Flow(FlowDirection.In)] Boolean red, [Flow(FlowDirection.In)] Boolean green, [Flow(FlowDirection.In)] bool blue, [Flow(FlowDirection.In)] Boolean alpha);

        [NativeApi(EntryPoint = "glTextureColorMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void TextureColorMask([Flow(FlowDirection.In)] Boolean red, [Flow(FlowDirection.In)] Boolean green, [Flow(FlowDirection.In)] Boolean blue, [Flow(FlowDirection.In)] bool alpha);

        [NativeApi(EntryPoint = "glTextureColorMaskSGIS", Convention = CallingConvention.Winapi)]
        public partial void TextureColorMask([Flow(FlowDirection.In)] Boolean red, [Flow(FlowDirection.In)] Boolean green, [Flow(FlowDirection.In)] Boolean blue, [Flow(FlowDirection.In)] Boolean alpha);

        public SgisTextureColorMask(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

