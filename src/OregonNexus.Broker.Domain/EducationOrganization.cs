// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

namespace OregonNexus.Broker.Domain;

public class EducationOrganization : BaseEntity, IAggregateRoot
{

    public EducationOrganization? ParentOrganization { get; set; }
    public Guid? ParentOrganizationId { get; set; }
    public Guid? AddressId { get; set; }
    public string Name { get; set; } = default!;
    public string? Number { get; set; } = default!;
    public EducationOrganizationType EducationOrganizationType { get; set; } = EducationOrganizationType.District;
    public string StreetNumberName { get; set; } = default!;
    public string City { get; set; } = default!;
    public string StateAbbreviation { get; set; } = default!;
    public string PostalCode { get; set; } = default!;
}

public enum EducationOrganizationType
{
    District,
    School
}
