using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector;

public abstract class DataPayloadContent : PayloadContent
{   
    public object? Content { get; set; }
    public abstract PayloadContentSchema Schema { get; }
}