using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector;

public interface ITransformer<IT, RT>
{
    public RT Map(
        IT objectToMap, 
        Domain.Student student, 
        EducationOrganization educationOrganization,
        Manifest manifest
    );
}