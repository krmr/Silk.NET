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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_line_rasterization")]
    public unsafe partial class ExtLineRasterization : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_line_rasterization";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetLineStippleEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetLineStipple([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint lineStippleFactor, [Count(Count = 0)] ushort lineStipplePattern);

        public ExtLineRasterization(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

