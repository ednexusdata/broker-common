using System;
using OregonNexus.Broker.Connector.Student;
using OregonNexus.Broker.Domain;

namespace OregonNexus.Broker.Connector.StudentLookup;

public interface IStudentLookupService
{
    public Task<List<StudentLookupResult>> SearchAsync(Domain.Student studentParameters);
}