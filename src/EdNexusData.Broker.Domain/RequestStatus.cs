// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

using System.ComponentModel;

namespace EdNexusData.Broker.Domain;

public enum RequestStatus
{
    [Description("Draft")]
    Draft,
    
    [Description("Waiting to Send")]
    WaitingToSend,

    [Description("Sending")]
    Sending,

    [Description("Sent")]
    Sent,

    [Description("Waiting Approval")]
    WaitingApproval,

    [Description("Approved")]
    Approved,

    [Description("Denied")]
    Denied,

    [Description("Declined")]
    Declined,

    [Description("Received")]
    Received,

    [Description("Waiting to Load")]
    WaitingToLoad,

    [Description("Loading")]
    Loading,

    [Description("Loaded")]
    Loaded,

    [Description("Waiting to Prepare")]
    WaitingToPrepare,

    [Description("Preparing")]
    Preparing,

    [Description("Prepared")]
    Prepared,

    [Description("Waiting to Import")]
    WaitingToImport,

    [Description("Importing")]
    Importing,

    [Description("Imported")]
    Imported
}