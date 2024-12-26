namespace EdNexusData.Broker.Core.Students;

public interface IStudentService
{
    public Task<IStudent?> FetchAsync(Student studentParameters);
}