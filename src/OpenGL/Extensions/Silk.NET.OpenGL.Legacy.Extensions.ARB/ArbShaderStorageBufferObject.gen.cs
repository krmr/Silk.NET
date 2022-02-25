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
    [Extension("ARB_shader_storage_buffer_object")]
    public unsafe partial class ArbShaderStorageBufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_shader_storage_buffer_object";
        [NativeApi(EntryPoint = "glShaderStorageBlockBinding", Convention = CallingConvention.Winapi)]
        public partial void ShaderStorageBlockBinding([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint storageBlockIndex, [Flow(FlowDirection.In)] uint storageBlockBinding);

        public ArbShaderStorageBufferObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

