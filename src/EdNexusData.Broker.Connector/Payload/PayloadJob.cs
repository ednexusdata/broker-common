using System.Text.Json;

namespace EdNexusData.Broker.Connector;

public abstract class PayloadJob
{
    public static bool AllowConfiguration = false;
    
    public static bool AllowMultiple = false;

    protected string? StudentUniqueId;
    
    protected JsonDocument? Configuration;

    public abstract Task<Status> StartAsync(string studentUniqueId, JsonDocument? configuration);

    public abstract Task<Status> ContinueAsync();

    public abstract Task<object?> FinishAsync();

    public enum Status
    {
        Continue,
        ContinueLater,
        Finish
    }
}