using System.Text.Json;
using EdNexusData.Broker.Common.Jobs;

namespace EdNexusData.Broker.Common.Worker;

public class Job
{
    public DateTimeOffset QueueDateTime { get; set; } = DateTime.UtcNow;
    public DateTimeOffset? StartDateTime { get; set; }
    public DateTimeOffset? FinishDateTime { get; set; }
    public string? JobType { get; set; }
    public JsonDocument? JobParameters { get; set; }
    public string? ReferenceType { get; set; }
    public Guid? ReferenceGuid { get; set; }
    public JobStatus JobStatus { get; set; } = JobStatus.Waiting;
    public string? WorkerInstance { get; set; }
    public string? WorkerState { get; set; }
    public string? WorkerLog { get; set; }
}