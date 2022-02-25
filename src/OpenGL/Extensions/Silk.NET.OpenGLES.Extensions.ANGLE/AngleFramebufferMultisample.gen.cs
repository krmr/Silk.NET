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

namespace Silk.NET.OpenGLES.Extensions.ANGLE
{
    [Extension("ANGLE_framebuffer_multisample")]
    public unsafe partial class AngleFramebufferMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "ANGLE_framebuffer_multisample";
        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleANGLE", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] ANGLE target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ANGLE internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleANGLE", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] ANGLE target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleANGLE", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ANGLE internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleANGLE", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        public AngleFramebufferMultisample(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

