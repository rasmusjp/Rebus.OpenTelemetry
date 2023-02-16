﻿using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace Rebus.Diagnostics
{
    public static class RebusDiagnosticConstants
    {
        public const string TraceStateHeaderName = "rbs-ot-tracestate";
        public const string BaggageHeaderName = "rbs-ot-correlation-context";
        

        public const string ConsumerActivityName = ActivitySourceName + ".Receive";
        public const string ProducerActivityName = ActivitySourceName + ".Send";

        public const string MessageSendDelayMeterName = MeterName + ".send.delay";
        public const string MessageSendSizeMeterName = MeterName + ".send.size";
        public const string MessageSendMeterName = MeterName + ".send";
        public const string MessageReceiveSizeMeterName = MeterName + ".received.size";
        public const string MessageReceiveDelayMeterName = MeterName + ".received.delay";
        public const string MessageReceivedMeterName = MeterName + ".received";

        public const string ActivitySourceName = "Rebus.Diagnostics";
        public const string MeterName = "Rebus.Diagnostics";

        public static readonly ActivitySource ActivitySource = new ActivitySource(ActivitySourceName,
                                                                                  typeof(RebusDiagnosticConstants).Assembly.GetName().Version.ToString());
        public static readonly Meter Meter = new Meter(MeterName, 
            typeof(RebusDiagnosticConstants).Assembly.GetName().Version.ToString());
    }
}

