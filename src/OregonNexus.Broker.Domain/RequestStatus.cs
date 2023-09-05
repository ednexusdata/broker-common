// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

namespace OregonNexus.Broker.Domain;

public enum RequestStatus
{
    Draft,
    WaitingToSend,
    Sending,
    Sent,
    WaitingApproval,
    Approved,
    Denied,
    Declined,
    Received,
    WaitingToImport,
    Importing,
    Imported
}