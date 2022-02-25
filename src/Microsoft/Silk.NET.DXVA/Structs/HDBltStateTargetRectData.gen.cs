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

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVAHD_BLT_STATE_TARGET_RECT_DATA")]
    public unsafe partial struct HDBltStateTargetRectData
    {
        public HDBltStateTargetRectData
        (
            int? enable = null,
            Silk.NET.Maths.Rectangle<int>? targetRect = null
        ) : this()
        {
            if (enable is not null)
            {
                Enable = enable.Value;
            }

            if (targetRect is not null)
            {
                TargetRect = targetRect.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Enable")]
        public int Enable;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "TargetRect")]
        public Silk.NET.Maths.Rectangle<int> TargetRect;
    }
}
