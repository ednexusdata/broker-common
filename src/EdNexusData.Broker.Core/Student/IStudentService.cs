namespace EdNexusData.Broker.Core.Student;

public interface IStudentService
{
    public Task<IStudent?> FetchAsync(Student studentParameters);
}