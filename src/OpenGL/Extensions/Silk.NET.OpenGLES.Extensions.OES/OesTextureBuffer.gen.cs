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

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_texture_buffer")]
    public unsafe partial class OesTextureBuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_texture_buffer";
        [NativeApi(EntryPoint = "glTexBufferOES", Convention = CallingConvention.Winapi)]
        public partial void TexBuffer([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBufferOES", Convention = CallingConvention.Winapi)]
        public partial void TexBuffer([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBufferOES", Convention = CallingConvention.Winapi)]
        public partial void TexBuffer([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBufferOES", Convention = CallingConvention.Winapi)]
        public partial void TexBuffer([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBufferRangeOES", Convention = CallingConvention.Winapi)]
        public partial void TexBufferRange([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTexBufferRangeOES", Convention = CallingConvention.Winapi)]
        public partial void TexBufferRange([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTexBufferRangeOES", Convention = CallingConvention.Winapi)]
        public partial void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTexBufferRangeOES", Convention = CallingConvention.Winapi)]
        public partial void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        public OesTextureBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

