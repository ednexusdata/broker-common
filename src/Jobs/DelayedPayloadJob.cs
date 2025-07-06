using System.Text.Json;

namespace EdNexusData.Broker.Common.Jobs;

public abstract class DelayedPayloadJob : PayloadJob
{
    protected string? StudentUniqueId;
    
    protected JsonDocument? Configuration;

    public abstract Task<DelayedJobStatus> StartAsync(
        string studentUniqueId,
        JsonDocument? configuration,
        IJobStatusService jobStatusService
    );

    public abstract Task<DelayedJobStatus> ContinueAsync(IJobStatusService jobStatusService);

    public abstract Task<object?> FinishAsync(IJobStatusService jobStatusService);

    public override Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration,
        IJobStatusService jobStatusService
    )
    {
        throw new NotImplementedException("ExecuteAsync not to be implemented for PayloadJob");
    }
}