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
    [NativeName("Name", "_DXVAHD_STREAM_STATE_ASPECT_RATIO_DATA")]
    public unsafe partial struct HDStreamStateAspectRatioData
    {
        public HDStreamStateAspectRatioData
        (
            int? enable = null,
            HDRational? sourceAspectRatio = null,
            HDRational? destinationAspectRatio = null
        ) : this()
        {
            if (enable is not null)
            {
                Enable = enable.Value;
            }

            if (sourceAspectRatio is not null)
            {
                SourceAspectRatio = sourceAspectRatio.Value;
            }

            if (destinationAspectRatio is not null)
            {
                DestinationAspectRatio = destinationAspectRatio.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Enable")]
        public int Enable;

        [NativeName("Type", "DXVAHD_RATIONAL")]
        [NativeName("Type.Name", "DXVAHD_RATIONAL")]
        [NativeName("Name", "SourceAspectRatio")]
        public HDRational SourceAspectRatio;

        [NativeName("Type", "DXVAHD_RATIONAL")]
        [NativeName("Type.Name", "DXVAHD_RATIONAL")]
        [NativeName("Name", "DestinationAspectRatio")]
        public HDRational DestinationAspectRatio;
    }
}
