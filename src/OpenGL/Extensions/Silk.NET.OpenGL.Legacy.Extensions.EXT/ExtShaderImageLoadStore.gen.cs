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
    [Extension("EXT_shader_image_load_store")]
    public unsafe partial class ExtShaderImageLoadStore : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_shader_image_load_store";
        [NativeApi(EntryPoint = "glBindImageTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] EXT access, [Flow(FlowDirection.In)] int format);

        [NativeApi(EntryPoint = "glBindImageTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] BufferAccessARB access, [Flow(FlowDirection.In)] int format);

        [NativeApi(EntryPoint = "glBindImageTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] Boolean layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] EXT access, [Flow(FlowDirection.In)] int format);

        [NativeApi(EntryPoint = "glBindImageTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] Boolean layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] BufferAccessARB access, [Flow(FlowDirection.In)] int format);

        [NativeApi(EntryPoint = "glMemoryBarrierEXT", Convention = CallingConvention.Winapi)]
        public partial void MemoryBarrier([Flow(FlowDirection.In)] uint barriers);

        [NativeApi(EntryPoint = "glMemoryBarrierEXT", Convention = CallingConvention.Winapi)]
        public partial void MemoryBarrier([Flow(FlowDirection.In)] MemoryBarrierMask barriers);

        public ExtShaderImageLoadStore(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

