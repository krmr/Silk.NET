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

namespace Silk.NET.XAudio
{
    [NativeName("Name", "IXAudio2EngineCallback")]
    public unsafe partial struct IXAudio2EngineCallback
    {
        public IXAudio2EngineCallback
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly void OnProcessingPassStart()
        {
            var @this = (IXAudio2EngineCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2EngineCallback*, void>)LpVtbl[0])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void OnProcessingPassEnd()
        {
            var @this = (IXAudio2EngineCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2EngineCallback*, void>)LpVtbl[1])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void OnCriticalError(int Error)
        {
            var @this = (IXAudio2EngineCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2EngineCallback*, int, void>)LpVtbl[2])(@this, Error);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2EngineCallback*, int, void>)LpVtbl[2])(@this, Error);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2EngineCallback*, int, void>)LpVtbl[2])(@this, Error);
            }
            #endif
        }

    }
}
