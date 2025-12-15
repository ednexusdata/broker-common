namespace EdNexusData.Broker.Common.EducationOrganizations;

public class EducationOrganization
{
    public Guid Id { get; set; }
    public EducationOrganization? ParentOrganization { get; set; }
    public Guid? ParentOrganizationId { get; set; }
    public string Name { get; set; } = default!;
    public string ShortName { get; set; } = default!;
    public string? Number { get; set; } = default!;
    public string? StateCode { get; set; } = default!;
    public string? NcesCode { get; set; } = default!;
    public string? CeebCode { get; set; } = default!;
    public EducationOrganizationType EducationOrganizationType { get; set; } = EducationOrganizationType.District;
}