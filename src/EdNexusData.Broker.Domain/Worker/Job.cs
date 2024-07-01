using System.Text.Json;

namespace EdNexusData.Broker.Domain.Worker;

public class Job : BaseEntity, IAggregateRoot
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
}