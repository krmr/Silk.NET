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
    [NativeName("AnonymousName", "__AnonymousRecord_dxva2trace_L71_C9")]
    [NativeName("Name", "DXVA2Trace_DecodeDevGetBufferData")]
    public unsafe partial struct DXVA2TraceDecodeDevGetBufferData
    {
        public DXVA2TraceDecodeDevGetBufferData
        (
            Silk.NET.Core.Win32Extras.EventTraceHeader? wmiHeader = null,
            ulong? pObject = null,
            uint? bufferType = null,
            int? enter = null
        ) : this()
        {
            if (wmiHeader is not null)
            {
                WmiHeader = wmiHeader.Value;
            }

            if (pObject is not null)
            {
                PObject = pObject.Value;
            }

            if (bufferType is not null)
            {
                BufferType = bufferType.Value;
            }

            if (enter is not null)
            {
                Enter = enter.Value;
            }
        }


        [NativeName("Type", "EVENT_TRACE_HEADER")]
        [NativeName("Type.Name", "EVENT_TRACE_HEADER")]
        [NativeName("Name", "wmiHeader")]
        public Silk.NET.Core.Win32Extras.EventTraceHeader WmiHeader;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "pObject")]
        public ulong PObject;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BufferType")]
        public uint BufferType;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Enter")]
        public int Enter;
    }
}
