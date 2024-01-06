// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com
using System.Text.Json;
using Ardalis.GuardClauses;

namespace OregonNexus.Broker.Domain;

public class Request : BaseEntity, IAggregateRoot
{
    public Guid? EducationOrganizationId { get; set; }
    public EducationOrganization? EducationOrganization { get; set; }
    public StudentRequest? Student { get; set; }
    public Manifest? RequestManifest { get; set; }
    public Guid? RequestProcessUserId { get; set; }
    public DateTime? InitialRequestSentDate { get; set; }
    public Manifest? ResponseManifest { get; set; }
    public Guid? ResponseProcessUserId { get; set; }
    public RequestStatus RequestStatus { get; set; } = RequestStatus.Draft;
    
    /*
    public string? _requestDetails { get; set; }
    public RequestDetails? RequestDetails
    {
        get { return _requestDetails == null ? null : JsonSerializer.Deserialize<RequestDetails>(_requestDetails); }
        set { _requestDetails = JsonSerializer.Serialize(value); }
    }
    */
}