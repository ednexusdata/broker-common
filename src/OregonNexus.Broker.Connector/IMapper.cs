using OregonNexus.Broker.Domain;

namespace OregonNexus.Broker.Connector;

public interface IMapper
{
    public object Map(object objectToMap, Domain.Student student, EducationOrganization educationOrganization);
}