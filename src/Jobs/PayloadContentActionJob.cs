using EdNexusData.Broker.Common.EducationOrganizations;
using EdNexusData.Broker.Common.PayloadContentActions;
using EdNexusData.Broker.Common.Students;

namespace EdNexusData.Broker.Common.Jobs;

public abstract class PayloadContentActionJob
{   
    public abstract Task<object?> ExecuteAsync(object mapping, 
        PayloadContentAction payloadContentAction, 
        IStudent student, 
        Student brokerStudent,
        EducationOrganization educationOrganization,
        IJobStatusService jobStatusService
    );
}