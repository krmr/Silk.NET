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
    [Extension("QCOM_motion_estimation")]
    public unsafe partial class QComMotionEstimation : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_motion_estimation";
        [NativeApi(EntryPoint = "glTexEstimateMotionQCOM", Convention = CallingConvention.Winapi)]
        public partial void TexEstimateMotion([Flow(FlowDirection.In)] uint @ref, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] uint output);

        [NativeApi(EntryPoint = "glTexEstimateMotionRegionsQCOM", Convention = CallingConvention.Winapi)]
        public partial void TexEstimateMotionRegion([Flow(FlowDirection.In)] uint @ref, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] uint output, [Flow(FlowDirection.In)] uint mask);

        public QComMotionEstimation(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

