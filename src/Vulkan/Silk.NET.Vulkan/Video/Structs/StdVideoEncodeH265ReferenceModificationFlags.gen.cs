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

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoEncodeH265ReferenceModificationFlags")]
    public unsafe partial struct StdVideoEncodeH265ReferenceModificationFlags
    {
        public StdVideoEncodeH265ReferenceModificationFlags
        (
            uint? refPicListModificationFlagL0 = null,
            uint? refPicListModificationFlagL1 = null
        ) : this()
        {
            if (refPicListModificationFlagL0 is not null)
            {
                RefPicListModificationFlagL0 = refPicListModificationFlagL0.Value;
            }

            if (refPicListModificationFlagL1 is not null)
            {
                RefPicListModificationFlagL1 = refPicListModificationFlagL1.Value;
            }
        }


        private uint _bitfield1;

        public uint RefPicListModificationFlagL0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint RefPicListModificationFlagL1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }
    }
}
