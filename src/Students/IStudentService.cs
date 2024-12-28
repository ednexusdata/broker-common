namespace EdNexusData.Broker.Common.Students;

public interface IStudentService
{
    public Task<IStudent?> FetchAsync(Student studentParameters);
}