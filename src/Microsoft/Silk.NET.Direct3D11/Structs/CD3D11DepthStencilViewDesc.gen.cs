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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "CD3D11_DEPTH_STENCIL_VIEW_DESC")]
    public unsafe partial struct CD3D11DepthStencilViewDesc
    {
        public CD3D11DepthStencilViewDesc
        (
            Silk.NET.DXGI.Format? format = null,
            DsvDimension? viewDimension = null,
            uint? flags = null,
            DepthStencilViewDescUnion? anonymous = null,
            Tex1DDsv? texture1D = null,
            Tex1DArrayDsv? texture1DArray = null,
            Tex2DDsv? texture2D = null,
            Tex2DArrayDsv? texture2DArray = null,
            Tex2DmsDsv? texture2DMS = null,
            Tex2DmsArrayDsv? texture2DMSArray = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (viewDimension is not null)
            {
                ViewDimension = viewDimension.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (texture1D is not null)
            {
                Texture1D = texture1D.Value;
            }

            if (texture1DArray is not null)
            {
                Texture1DArray = texture1DArray.Value;
            }

            if (texture2D is not null)
            {
                Texture2D = texture2D.Value;
            }

            if (texture2DArray is not null)
            {
                Texture2DArray = texture2DArray.Value;
            }

            if (texture2DMS is not null)
            {
                Texture2DMS = texture2DMS.Value;
            }

            if (texture2DMSArray is not null)
            {
                Texture2DMSArray = texture2DMSArray.Value;
            }
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "D3D11_DSV_DIMENSION")]
        [NativeName("Type.Name", "D3D11_DSV_DIMENSION")]
        [NativeName("Name", "ViewDimension")]
        public DsvDimension ViewDimension;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Flags")]
        public uint Flags;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d11_L4429_C5")]
        [NativeName("Name", "anonymous1")]
        public DepthStencilViewDescUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex1DDsv Texture1D
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture1D;
        }
#else
        public Tex1DDsv Texture1D
        {
            get => Anonymous.Texture1D;
            set => Anonymous.Texture1D = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex1DArrayDsv Texture1DArray
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture1DArray;
        }
#else
        public Tex1DArrayDsv Texture1DArray
        {
            get => Anonymous.Texture1DArray;
            set => Anonymous.Texture1DArray = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex2DDsv Texture2D
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture2D;
        }
#else
        public Tex2DDsv Texture2D
        {
            get => Anonymous.Texture2D;
            set => Anonymous.Texture2D = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex2DArrayDsv Texture2DArray
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture2DArray;
        }
#else
        public Tex2DArrayDsv Texture2DArray
        {
            get => Anonymous.Texture2DArray;
            set => Anonymous.Texture2DArray = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex2DmsDsv Texture2DMS
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture2DMS;
        }
#else
        public Tex2DmsDsv Texture2DMS
        {
            get => Anonymous.Texture2DMS;
            set => Anonymous.Texture2DMS = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex2DmsArrayDsv Texture2DMSArray
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture2DMSArray;
        }
#else
        public Tex2DmsArrayDsv Texture2DMSArray
        {
            get => Anonymous.Texture2DMSArray;
            set => Anonymous.Texture2DMSArray = value;
        }
#endif

    }
}
