using EdNexusData.Broker.Common.Students;

namespace EdNexusData.Broker.Common.StudentLookup;

public interface IStudentLookupService
{
    public Task<List<StudentLookupResult>> SearchAsync(Student studentParameters);
}