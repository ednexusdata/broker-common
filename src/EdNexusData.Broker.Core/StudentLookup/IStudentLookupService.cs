using EdNexusData.Broker.Core.Students;

namespace EdNexusData.Broker.Core.StudentLookup;

public interface IStudentLookupService
{
    public Task<List<StudentLookupResult>> SearchAsync(Student studentParameters);
}