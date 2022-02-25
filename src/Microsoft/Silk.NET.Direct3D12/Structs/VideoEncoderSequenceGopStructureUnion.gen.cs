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

namespace Silk.NET.Direct3D12
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12video_L6145_C5")]
    public unsafe partial struct VideoEncoderSequenceGopStructureUnion
    {
        public VideoEncoderSequenceGopStructureUnion
        (
            VideoEncoderSequenceGopStructureH264* pH264GroupOfPictures = null,
            VideoEncoderSequenceGopStructureHevc* pHEVCGroupOfPictures = null
        ) : this()
        {
            if (pH264GroupOfPictures is not null)
            {
                PH264GroupOfPictures = pH264GroupOfPictures;
            }

            if (pHEVCGroupOfPictures is not null)
            {
                PHEVCGroupOfPictures = pHEVCGroupOfPictures;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264 *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264 *")]
        [NativeName("Name", "pH264GroupOfPictures")]
        public VideoEncoderSequenceGopStructureH264* PH264GroupOfPictures;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC *")]
        [NativeName("Name", "pHEVCGroupOfPictures")]
        public VideoEncoderSequenceGopStructureHevc* PHEVCGroupOfPictures;
    }
}
