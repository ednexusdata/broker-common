namespace EdNexusData.Broker.Core.StudentLookup;

public interface IStudentLookupService
{
    public Task<List<StudentLookupResult>> SearchAsync(Student.Student studentParameters);
}