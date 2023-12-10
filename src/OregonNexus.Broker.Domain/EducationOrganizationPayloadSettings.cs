// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

using System.Text.Json;

namespace OregonNexus.Broker.Domain;

public class EducationOrganizationPayloadSettings : BaseEntity, IAggregateRoot
{
    public EducationOrganization? EducationOrganization { get; set; }
    public Guid? EducationOrganizationId { get; set; }
    public PayloadDirection? PayloadDirection { get; set; }
    public string Payload { get; set; } = default!;
    public List<PayloadSettingsContentType> Settings { get; set; } = default!;
}
