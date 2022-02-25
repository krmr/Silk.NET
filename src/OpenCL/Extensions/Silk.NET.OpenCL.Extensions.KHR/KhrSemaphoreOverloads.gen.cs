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

namespace Silk.NET.OpenCL.Extensions.KHR
{
    public static class KhrSemaphoreOverloads
    {
        public static unsafe nint CreateSemaphoreWithProperties(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ulong* sema_props, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateSemaphoreWithProperties(context, sema_props, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateSemaphoreWithProperties(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_props, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateSemaphoreWithProperties(context, in sema_props.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateSemaphoreWithProperties(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_props, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateSemaphoreWithProperties(context, in sema_props.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueSignalSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSignalSemaphores(command_queue, num_sema_objects, sema_objects, sema_payload_list, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSignalSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSignalSemaphores(command_queue, num_sema_objects, sema_objects, sema_payload_list, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSignalSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSignalSemaphores(command_queue, num_sema_objects, sema_objects, sema_payload_list, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSignalSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSignalSemaphores(command_queue, num_sema_objects, sema_objects, in sema_payload_list.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSignalSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSignalSemaphores(command_queue, num_sema_objects, sema_objects, in sema_payload_list.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSignalSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSignalSemaphores(command_queue, num_sema_objects, sema_objects, in sema_payload_list.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSignalSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSignalSemaphores(command_queue, num_sema_objects, sema_objects, in sema_payload_list.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSignalSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSignalSemaphores(command_queue, num_sema_objects, in sema_objects.GetPinnableReference(), sema_payload_list, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSignalSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSignalSemaphores(command_queue, num_sema_objects, in sema_objects.GetPinnableReference(), sema_payload_list, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSignalSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSignalSemaphores(command_queue, num_sema_objects, in sema_objects.GetPinnableReference(), sema_payload_list, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSignalSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSignalSemaphores(command_queue, num_sema_objects, in sema_objects.GetPinnableReference(), sema_payload_list, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSignalSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSignalSemaphores(command_queue, num_sema_objects, in sema_objects.GetPinnableReference(), in sema_payload_list.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSignalSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSignalSemaphores(command_queue, num_sema_objects, in sema_objects.GetPinnableReference(), in sema_payload_list.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSignalSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSignalSemaphores(command_queue, num_sema_objects, in sema_objects.GetPinnableReference(), in sema_payload_list.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSignalSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSignalSemaphores(command_queue, num_sema_objects, in sema_objects.GetPinnableReference(), in sema_payload_list.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWaitSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWaitSemaphores(command_queue, num_sema_objects, sema_objects, sema_payload_list, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWaitSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWaitSemaphores(command_queue, num_sema_objects, sema_objects, sema_payload_list, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWaitSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWaitSemaphores(command_queue, num_sema_objects, sema_objects, sema_payload_list, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWaitSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWaitSemaphores(command_queue, num_sema_objects, sema_objects, in sema_payload_list.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWaitSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWaitSemaphores(command_queue, num_sema_objects, sema_objects, in sema_payload_list.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWaitSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWaitSemaphores(command_queue, num_sema_objects, sema_objects, in sema_payload_list.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWaitSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWaitSemaphores(command_queue, num_sema_objects, sema_objects, in sema_payload_list.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWaitSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWaitSemaphores(command_queue, num_sema_objects, in sema_objects.GetPinnableReference(), sema_payload_list, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWaitSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWaitSemaphores(command_queue, num_sema_objects, in sema_objects.GetPinnableReference(), sema_payload_list, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWaitSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWaitSemaphores(command_queue, num_sema_objects, in sema_objects.GetPinnableReference(), sema_payload_list, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWaitSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWaitSemaphores(command_queue, num_sema_objects, in sema_objects.GetPinnableReference(), sema_payload_list, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWaitSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWaitSemaphores(command_queue, num_sema_objects, in sema_objects.GetPinnableReference(), in sema_payload_list.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWaitSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWaitSemaphores(command_queue, num_sema_objects, in sema_objects.GetPinnableReference(), in sema_payload_list.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWaitSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWaitSemaphores(command_queue, num_sema_objects, in sema_objects.GetPinnableReference(), in sema_payload_list.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWaitSemaphores(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> sema_objects, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWaitSemaphores(command_queue, num_sema_objects, in sema_objects.GetPinnableReference(), in sema_payload_list.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int GetSemaphoreInfo(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint sema_object, [Flow(FlowDirection.In)] KHR param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetSemaphoreInfo(sema_object, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetSemaphoreInfo<T0>(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint sema_object, [Flow(FlowDirection.In)] KHR param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSemaphoreInfo(sema_object, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetSemaphoreInfo<T0>(this KhrSemaphore thisApi, [Flow(FlowDirection.In)] nint sema_object, [Flow(FlowDirection.In)] KHR param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSemaphoreInfo(sema_object, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

    }
}

