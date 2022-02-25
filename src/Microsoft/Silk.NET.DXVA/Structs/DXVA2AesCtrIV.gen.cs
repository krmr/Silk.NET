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
    [NativeName("Name", "_DXVA2_AES_CTR_IV")]
    public unsafe partial struct DXVA2AesCtrIV
    {
        public DXVA2AesCtrIV
        (
            ulong? iV = null,
            ulong? count = null
        ) : this()
        {
            if (iV is not null)
            {
                IV = iV.Value;
            }

            if (count is not null)
            {
                Count = count.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "IV")]
        public ulong IV;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Count")]
        public ulong Count;
    }
}
