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
    [NativeName("Name", "_DXVAHD_STREAM_STATE_SOURCE_RECT_DATA")]
    public unsafe partial struct HDStreamStateSourceRectData
    {
        public HDStreamStateSourceRectData
        (
            int? enable = null,
            Silk.NET.Maths.Rectangle<int>? sourceRect = null
        ) : this()
        {
            if (enable is not null)
            {
                Enable = enable.Value;
            }

            if (sourceRect is not null)
            {
                SourceRect = sourceRect.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Enable")]
        public int Enable;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "SourceRect")]
        public Silk.NET.Maths.Rectangle<int> SourceRect;
    }
}
