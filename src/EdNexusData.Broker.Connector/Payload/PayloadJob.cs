using System.Text.Json;

namespace EdNexusData.Broker.Connector;

public abstract class PayloadJob
{
    public static bool AllowConfiguration = false;
    
    public static bool AllowMultiple = false;
    
    public abstract Task<(Status Status, JsonDocument? Resubmit)> StartAsync(string studentUniqueId, JsonDocument? configuration);

    public abstract Task<(Status Status, JsonDocument? Resubmit)> ContinueAsync(JsonDocument? resubmit, string? studentUniqueId, JsonDocument? configuration);

    public abstract Task<object?> FinishAsync(string studentUniqueId, JsonDocument? configuration);

    public enum Status
    {
        Continue,
        Finish
    }
}