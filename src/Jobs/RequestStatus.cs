// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com
using System.ComponentModel;

namespace EdNexusData.Broker.Common.Jobs;

public enum RequestStatus
{
    [Description("Draft")]
    Draft,
    
    [Description("Waiting to Request")]
    WaitingToRequest,

    [Description("Requesting")]
    Requesting,

    [Description("Requested")]
    Requested,

    [Description("Received")]
    Received,

    [Description("Waiting to Extract")]
    WaitingToExtract,

    [Description("Extracting")]
    Extracting,

    [Description("Extracted")]
    Extracted,

    [Description("Waiting to Transmit")]
    WaitingToTransmit,

    [Description("Transmitting")]
    Transmitting,

    [Description("Transmitted")]
    Transmitted,

    [Description("In-Progress")]
    InProgress,

    [Description("Finished")]
    Finished,
    
    [Description("Re-opened")]
    Reopened,

    [Description("Closed")]
    Closed
}