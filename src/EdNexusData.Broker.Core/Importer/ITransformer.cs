using EdNexusData.Broker.Core.EducationOrganizations;
using EdNexusData.Broker.Core.Importer;
using EdNexusData.Broker.Core.Students;

namespace EdNexusData.Broker.Core;

public interface ITransformer<IT, RT>
{
    public RT Map(
        IT objectToMap, 
        Student student, 
        EducationOrganization educationOrganization,
        Manifest manifest
    );
}