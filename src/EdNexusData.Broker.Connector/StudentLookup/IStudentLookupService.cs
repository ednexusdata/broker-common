using System;
using EdNexusData.Broker.Connector.Student;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.StudentLookup;

public interface IStudentLookupService
{
    public Task<List<StudentLookupResult>> SearchAsync(Domain.Student studentParameters);
}