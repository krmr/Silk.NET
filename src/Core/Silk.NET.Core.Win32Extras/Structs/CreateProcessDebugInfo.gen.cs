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
    [NativeName("Name", "_CREATE_PROCESS_DEBUG_INFO")]
    public unsafe partial struct CreateProcessDebugInfo
    {
        public CreateProcessDebugInfo
        (
            void* hFile = null,
            void* hProcess = null,
            void* hThread = null,
            void* lpBaseOfImage = null,
            uint? dwDebugInfoFileOffset = null,
            uint? nDebugInfoSize = null,
            void* lpThreadLocalBase = null,
            PfnPthreadStartRoutine? lpStartAddress = null,
            void* lpImageName = null,
            ushort? fUnicode = null
        ) : this()
        {
            if (hFile is not null)
            {
                HFile = hFile;
            }

            if (hProcess is not null)
            {
                HProcess = hProcess;
            }

            if (hThread is not null)
            {
                HThread = hThread;
            }

            if (lpBaseOfImage is not null)
            {
                LpBaseOfImage = lpBaseOfImage;
            }

            if (dwDebugInfoFileOffset is not null)
            {
                DwDebugInfoFileOffset = dwDebugInfoFileOffset.Value;
            }

            if (nDebugInfoSize is not null)
            {
                NDebugInfoSize = nDebugInfoSize.Value;
            }

            if (lpThreadLocalBase is not null)
            {
                LpThreadLocalBase = lpThreadLocalBase;
            }

            if (lpStartAddress is not null)
            {
                LpStartAddress = lpStartAddress.Value;
            }

            if (lpImageName is not null)
            {
                LpImageName = lpImageName;
            }

            if (fUnicode is not null)
            {
                FUnicode = fUnicode.Value;
            }
        }


        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "hFile")]
        public void* HFile;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "hProcess")]
        public void* HProcess;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "hThread")]
        public void* HThread;

        [NativeName("Type", "LPVOID")]
        [NativeName("Type.Name", "LPVOID")]
        [NativeName("Name", "lpBaseOfImage")]
        public void* LpBaseOfImage;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwDebugInfoFileOffset")]
        public uint DwDebugInfoFileOffset;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "nDebugInfoSize")]
        public uint NDebugInfoSize;

        [NativeName("Type", "LPVOID")]
        [NativeName("Type.Name", "LPVOID")]
        [NativeName("Name", "lpThreadLocalBase")]
        public void* LpThreadLocalBase;

        [NativeName("Type", "LPTHREAD_START_ROUTINE")]
        [NativeName("Type.Name", "LPTHREAD_START_ROUTINE")]
        [NativeName("Name", "lpStartAddress")]
        public PfnPthreadStartRoutine LpStartAddress;

        [NativeName("Type", "LPVOID")]
        [NativeName("Type.Name", "LPVOID")]
        [NativeName("Name", "lpImageName")]
        public void* LpImageName;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "fUnicode")]
        public ushort FUnicode;
    }
}
