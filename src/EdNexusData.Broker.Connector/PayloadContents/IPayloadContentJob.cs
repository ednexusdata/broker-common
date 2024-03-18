using EdNexusData.Broker.Connector.PayloadContentTypes;

namespace EdNexusData.Broker.Connector.PayloadContents;

public interface IPayloadContentJob
{
    public Task<PayloadContentType> ExecuteAsync(string studentUniqueId);
}