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

namespace Silk.NET.OpenGLES.Extensions.OES
{
    public static class OesTexture3DOverloads
    {
        public static unsafe void CompressedTexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexSubImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexSubImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexSubImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void CompressedTexSubImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, in data.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] OES format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this OesTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

    }
}

