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

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_TRACE_GUID_REGISTRATION")]
    public unsafe partial struct TraceGuidRegistration
    {
        public TraceGuidRegistration
        (
            Guid* guid = null,
            void* regHandle = null
        ) : this()
        {
            if (guid is not null)
            {
                Guid = guid;
            }

            if (regHandle is not null)
            {
                RegHandle = regHandle;
            }
        }


        [NativeName("Type", "LPCGUID")]
        [NativeName("Type.Name", "LPCGUID")]
        [NativeName("Name", "Guid")]
        public Guid* Guid;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "RegHandle")]
        public void* RegHandle;
    }
}
