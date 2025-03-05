using EdNexusData.Broker.Common.EducationOrganizations;
using EdNexusData.Broker.Common.Importer;
using EdNexusData.Broker.Common.PayloadContents;
using EdNexusData.Broker.Common.Students;

namespace EdNexusData.Broker.Common;

public interface ITransformer<IT, RT>
{
    public Task<RT> Map(
        IT objectToMap, 
        Student student, 
        EducationOrganization educationOrganization,
        Manifest manifest,
        List<DataPayloadContent>? additionalContents = null
    );
}