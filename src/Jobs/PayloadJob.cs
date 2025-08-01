using System.Text.Json;

namespace EdNexusData.Broker.Common.Jobs;

public abstract class PayloadJob
{
    public static bool AllowConfiguration = false;
    
    public static bool AllowMultiple = false;

    public IJobStatusService? JobStatusService;
    
    public abstract Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration,
        IJobStatusService jobStatusService
    );
}