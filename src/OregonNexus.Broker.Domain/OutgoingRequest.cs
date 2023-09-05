// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

namespace OregonNexus.Broker.Domain;

public class OutgoingRequest : BaseEntity, IAggregateRoot
{
    public string? RequestDetails { get; set; }
    public DateTime RequestDate { get; set; }
    public Guid? EducationOrganizationId { get; set; }
    public EducationOrganization? EducationOrganization { get; set; }
    public Guid? ProcessUserId { get; set; }
    public User? ProcessUser { get; set; }
    public string? Student { get; set; }
    public RequestStatus RequestStatus { get; set; } = RequestStatus.WaitingApproval;
}