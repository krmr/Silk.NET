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
    [NativeName("Name", "_DXVAHD_STREAM_STATE_LUMA_KEY_DATA")]
    public unsafe partial struct HDStreamStateLumaKeyData
    {
        public HDStreamStateLumaKeyData
        (
            int? enable = null,
            float? lower = null,
            float? upper = null
        ) : this()
        {
            if (enable is not null)
            {
                Enable = enable.Value;
            }

            if (lower is not null)
            {
                Lower = lower.Value;
            }

            if (upper is not null)
            {
                Upper = upper.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Enable")]
        public int Enable;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Lower")]
        public float Lower;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Upper")]
        public float Upper;
    }
}
