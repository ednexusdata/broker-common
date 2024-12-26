using EdNexusData.Broker.Core.PayloadContentActions;

namespace EdNexusData.Broker.Core.Jobs;

public interface IJobStatusService
{
    public Task UpdateJobStatus(JobStatus? newJobStatus, string? message, params object?[] messagePlaceholders);

    public Task UpdateRequestStatus(RequestStatus? newRequestStatus, string? message, params object?[] messagePlaceholders);

    public Task UpdatePayloadContentActionStatus(PayloadContentActionStatus? newPayloadContentActionStatus, string? message, params object?[] messagePlaceholders);
}