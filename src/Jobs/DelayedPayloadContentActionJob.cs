using System.Text.Json;
using EdNexusData.Broker.Common.EducationOrganizations;
using EdNexusData.Broker.Common.PayloadContentActions;
using EdNexusData.Broker.Common.Students;

namespace EdNexusData.Broker.Common.Jobs;

public abstract class DelayedPayloadContentActionJob : PayloadContentActionJob
{
    public abstract Task<DelayedJobStatus> StartAsync(
        object mapping, 
        PayloadContentAction payloadContentAction, 
        IStudent student, 
        Student brokerStudent,
        EducationOrganization educationOrganization,
        IJobStatusService jobStatusService
    );

    public abstract Task<DelayedJobStatus> ContinueAsync(IJobStatusService jobStatusService);

    public abstract Task<object?> FinishAsync(IJobStatusService jobStatusService);

    public override Task<object?> ExecuteAsync(
        object mapping, 
        PayloadContentAction payloadContentAction, 
        IStudent student, 
        Student brokerStudent,
        EducationOrganization educationOrganization,
        IJobStatusService jobStatusService
    )
    {
        throw new NotImplementedException("ExecuteAsync not to be implemented for PayloadJob");
    }
}