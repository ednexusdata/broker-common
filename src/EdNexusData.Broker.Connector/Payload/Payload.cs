using EdNexusData.Broker.Connector.PayloadContentTypes;

namespace EdNexusData.Broker.Connector.Payload;

public abstract class Payload : IPayload
{
    public List<PayloadContentType> PayloadContents => new List<PayloadContentType>();
}
