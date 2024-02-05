using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.PayloadContents;

public interface IPayloadContentJob
{
    public Task<T> ExecuteAsync<T>(string studentUniqueId);
}