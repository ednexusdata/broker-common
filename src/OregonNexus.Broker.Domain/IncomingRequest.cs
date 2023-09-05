// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

namespace OregonNexus.Broker.Domain;

public class IncomingRequest : BaseEntity, IAggregateRoot
{
    public Guid? EducationOrganizationId { get; set; }
    public EducationOrganization? EducationOrganization { get; set; }
    public Guid? RequestUserId { get; set; }
    public User? RequestUser { get; set; }
    public DateTime RequestDate { get; set; }
    public string? Student { get; set; }
    public RequestStatus RequestStatus { get; set; } = RequestStatus.Draft;
}