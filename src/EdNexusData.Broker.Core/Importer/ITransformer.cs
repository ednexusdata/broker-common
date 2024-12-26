using EdNexusData.Broker.Core.Importer;

namespace EdNexusData.Broker.Core;

public interface ITransformer<IT, RT>
{
    public RT Map(
        IT objectToMap, 
        Contracts.Student student, 
        EducationOrganization.EducationOrganization educationOrganization,
        Manifest manifest
    );
}