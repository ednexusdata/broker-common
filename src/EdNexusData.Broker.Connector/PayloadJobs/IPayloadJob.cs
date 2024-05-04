namespace EdNexusData.Broker.Connector.Payload.Jobs;

public interface IPayloadJob
{
    public Task<object?> ExecuteAsync(string studentUniqueId);
}