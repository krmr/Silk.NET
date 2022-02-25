// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.XAudio
{
    [Flags]
    [NativeName("Name", "_AudioSessionState")]
    public enum AudioSessionState : int
    {
        [NativeName("Name", "AudioSessionStateInactive")]
        AudioSessionStateInactive = 0x0,
        [NativeName("Name", "AudioSessionStateActive")]
        AudioSessionStateActive = 0x1,
        [NativeName("Name", "AudioSessionStateExpired")]
        AudioSessionStateExpired = 0x2,
    }
}
