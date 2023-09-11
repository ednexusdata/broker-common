// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com
using System.Text.Json;

namespace OregonNexus.Broker.Domain;

public class OutgoingRequest : BaseEntity, IAggregateRoot
{
    public string? _requestDetails { get; set; }
    public DateTime RequestDate { get; set; }
    public Guid? EducationOrganizationId { get; set; }
    public EducationOrganization? EducationOrganization { get; set; }
    public Guid? ProcessUserId { get; set; }
    public User? ProcessUser { get; set; }
    public string? Student { get; set; }
    public RequestStatus RequestStatus { get; set; } = RequestStatus.WaitingApproval;

    public RequestDetails? RequestDetails
    {
        get { return _requestDetails == null ? null : JsonSerializer.Deserialize<RequestDetails>(_requestDetails); }
        set { _requestDetails = JsonSerializer.Serialize(value); }
    }

    public List<PayloadContent> PayloadContents { get; set; } = new List<PayloadContent>();
}