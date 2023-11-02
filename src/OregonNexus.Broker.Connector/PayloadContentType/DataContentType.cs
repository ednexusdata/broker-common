namespace OregonNexus.Broker.Connector.PayloadContentTypes;

public abstract class DataContentType : PayloadContentType
{
    public abstract string Schema { get; }
    public abstract string SchemaVersion { get; }
}