using EdNexusData.Broker.Core.EducationOrganizations;

namespace EdNexusData.Broker.Core.Students;

public class StudentAttributes
{
    public string? Grade { get; set; }
    public string? Gender { get; set; }
    public EducationOrganization? District { get; set; }
    public EducationOrganization? School { get; set; }
}