using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.Payload.Contents;

public abstract class DataPayloadContent : PayloadContent
{   
    public abstract PayloadContentSchema Schema { get; }
}