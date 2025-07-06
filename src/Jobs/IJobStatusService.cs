using EdNexusData.Broker.Common.PayloadContentActions;

namespace EdNexusData.Broker.Common.Jobs;

public interface IJobStatusService
{
    public Task UpdateJobStatus(
        JobStatus? newJobStatus,
        string? message,
        params object?[] messagePlaceholders
    );

    public Task UpdateRequestStatus(
        RequestStatus? newRequestStatus,
        string? message,
        params object?[] messagePlaceholders
    );

    public Task UpdatePayloadContentActionStatus(
        PayloadContentActionStatus? newPayloadContentActionStatus,
        string? message,
        params object?[] messagePlaceholders
    );
}