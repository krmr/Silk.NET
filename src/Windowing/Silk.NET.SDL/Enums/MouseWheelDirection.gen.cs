// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_mouse_L66_C9")]
    [NativeName("Name", "SDL_MouseWheelDirection")]
    public enum MouseWheelDirection : int
    {
        [NativeName("Name", "SDL_MOUSEWHEEL_NORMAL")]
        MousewheelNormal = 0x0,
        [NativeName("Name", "SDL_MOUSEWHEEL_FLIPPED")]
        MousewheelFlipped = 0x1,
    }
}
