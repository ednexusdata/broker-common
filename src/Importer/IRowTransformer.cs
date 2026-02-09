using EdNexusData.Broker.Common.EducationOrganizations;
using EdNexusData.Broker.Common.Jobs;
using EdNexusData.Broker.Common.PayloadContents;
using EdNexusData.Broker.Common.Requests;
using EdNexusData.Broker.Common.Students;

namespace EdNexusData.Broker.Common;

public interface IRowTransformer<IT, RT> : ITransformer<IT, RT>
{
    public Task<RT> Map(
        IT objectToMap, 
        Student student, 
        EducationOrganization educationOrganization,
        Manifest manifest,
        IJobStatusService jobStatusService,
        List<DataPayloadContent>? additionalContents = null
    );
}