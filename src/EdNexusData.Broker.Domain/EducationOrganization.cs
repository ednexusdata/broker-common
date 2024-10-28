// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

using System.Text.Json.Serialization;

namespace EdNexusData.Broker.Domain;

public class EducationOrganization : BaseEntity, IAggregateRoot
{
    public EducationOrganization? ParentOrganization { get; set; }
    public Guid? ParentOrganizationId { get; set; }
    public string Name { get; set; } = default!;
    public string? Number { get; set; } = default!;
    public EducationOrganizationType EducationOrganizationType { get; set; } = EducationOrganizationType.District;
    public Address? Address { get; set; }
    public string? Domain { get; set; }
    public string? TimeZone { get; set; }
    public List<EducationOrganizationContact>? Contacts { get; set; }

    public virtual ICollection<EducationOrganization>? EducationOrganizations { get; set; }
}

public enum EducationOrganizationType
{
    District,
    School
}
