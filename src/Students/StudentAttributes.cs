using EdNexusData.Broker.Common.EducationOrganizations;

namespace EdNexusData.Broker.Common.Students;

public class StudentAttributes
{
    public string? Grade { get; set; }
    public string? Gender { get; set; }
    public EducationOrganization? District { get; set; }
    public EducationOrganization? School { get; set; }
}