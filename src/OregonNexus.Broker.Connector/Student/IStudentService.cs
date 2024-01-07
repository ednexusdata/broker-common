namespace OregonNexus.Broker.Connector.Student;

public interface IStudentService
{
    public Task<IStudent?> FetchAsync(Domain.Student studentParameters);
}