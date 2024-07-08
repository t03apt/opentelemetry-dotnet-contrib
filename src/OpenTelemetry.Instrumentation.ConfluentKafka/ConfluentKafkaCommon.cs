// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

using System.Diagnostics;
using System.Diagnostics.Metrics;
using OpenTelemetry.Internal;
using OpenTelemetry.Trace;

namespace OpenTelemetry.Instrumentation.ConfluentKafka;

#pragma warning disable RS0016 // Add public types and members to the declared API
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
public static class ConfluentKafkaCommon
{
    public static readonly string InstrumentationName = typeof(ConfluentKafkaCommon).Assembly.GetName().Name!;
    public static readonly string InstrumentationVersion = typeof(ConfluentKafkaCommon).Assembly.GetPackageVersion();
    internal static readonly ActivitySource ActivitySource = new(InstrumentationName, InstrumentationVersion);
    internal static readonly Meter Meter = new(InstrumentationName, InstrumentationVersion);
    internal static readonly Counter<long> ReceiveMessagesCounter = Meter.CreateCounter<long>(SemanticConventions.MetricMessagingReceiveMessages);
    internal static readonly Histogram<double> ReceiveDurationHistogram = Meter.CreateHistogram<double>(SemanticConventions.MetricMessagingReceiveDuration);
    internal static readonly Counter<long> PublishMessagesCounter = Meter.CreateCounter<long>(SemanticConventions.MetricMessagingPublishMessages);
    internal static readonly Histogram<double> PublishDurationHistogram = Meter.CreateHistogram<double>(SemanticConventions.MetricMessagingPublishDuration);
}
#pragma warning restore RS0016 // Add public types and members to the declared API
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
