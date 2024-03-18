// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com
using System.Text.Json;
using Ardalis.GuardClauses;

namespace EdNexusData.Broker.Domain;

public class RequestAddress
{
    public District? District { get; set; }
    public School? School { get; set; }
    public EducationOrganizationContact? Sender { get; set; }

    public string? BrokerAddress { get; set; }
}