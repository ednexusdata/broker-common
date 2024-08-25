using System.Text.Json;

namespace EdNexusData.Broker.Connector;

public abstract class DelayedPayloadJob : PayloadJob
{
    protected string? StudentUniqueId;
    
    protected JsonDocument? Configuration;

    public abstract Task<Status> StartAsync(string studentUniqueId, JsonDocument? configuration);

    public abstract Task<Status> ContinueAsync();

    public abstract Task<object?> FinishAsync();

    public override Task<object?> ExecuteAsync(string studentUniqueId, JsonDocument? configuration)
    {
        throw new NotImplementedException("ExecuteAsync not to be implemented for PayloadJob");
    }

    public enum Status
    {
        Continue,
        ContinueLater,
        Finish
    }
}