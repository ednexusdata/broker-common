using OregonNexus.Broker.Domain;

namespace OregonNexus.Broker.Connector.StudentLookup;

public interface IStudentLookupService
{
    public Task<List<StudentLookupResult>> SearchAsync(Student studentParameters);
}