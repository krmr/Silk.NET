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

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_shading_rate")]
    public unsafe partial class QComShadingRate : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_shading_rate";
        [NativeApi(EntryPoint = "glShadingRateQCOM", Convention = CallingConvention.Winapi)]
        public partial void ShadingRate([Flow(FlowDirection.In)] QCOM rate);

        [NativeApi(EntryPoint = "glShadingRateQCOM", Convention = CallingConvention.Winapi)]
        public partial void ShadingRate([Flow(FlowDirection.In)] ShadingRateQCOM rate);

        public QComShadingRate(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

