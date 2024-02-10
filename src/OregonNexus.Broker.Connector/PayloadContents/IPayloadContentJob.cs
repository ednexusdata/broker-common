using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.PayloadContents;

public interface IPayloadContentJob
{
    public Task<PayloadContentType> ExecuteAsync(string studentUniqueId);
}