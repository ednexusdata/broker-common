using EdNexusData.Broker.Common.EducationOrganizations;

namespace EdNexusData.Broker.Common.Requests;

public class RequestAddress
{
    public District? District { get; set; }
    public School? School { get; set; }
    public EducationOrganizationContact? Sender { get; set; }

    public string? BrokerAddress { get; set; }
}