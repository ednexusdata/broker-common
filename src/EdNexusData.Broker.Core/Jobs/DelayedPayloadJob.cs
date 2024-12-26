using System.Text.Json;

namespace EdNexusData.Broker.Core.Jobs;

public abstract class DelayedPayloadJob : PayloadJob
{
    protected string? StudentUniqueId;
    
    protected JsonDocument? Configuration;

    public abstract Task<DelayedJobStatus> StartAsync(string studentUniqueId, JsonDocument? configuration);

    public abstract Task<DelayedJobStatus> ContinueAsync();

    public abstract Task<object?> FinishAsync();

    public override Task<object?> ExecuteAsync(string studentUniqueId, JsonDocument? configuration)
    {
        throw new NotImplementedException("ExecuteAsync not to be implemented for PayloadJob");
    }
}