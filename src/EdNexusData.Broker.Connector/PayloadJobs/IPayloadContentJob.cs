using EdNexusData.Broker.Connector.Payload.Contents;

namespace EdNexusData.Broker.Connector.Payload.Jobs;

public interface IPayloadContentJob : IPayloadJob
{
    public new Task<PayloadContent> ExecuteAsync(string studentUniqueId);
}