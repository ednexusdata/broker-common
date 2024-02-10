namespace OregonNexus.Broker.Connector.PayloadContentTypes;

public abstract class PayloadContentType
{
    public abstract string ContentType { get; }
    public abstract string Schema { get; }
    public abstract string SchemaVersion { get; }
    public object? Content { get; set; }

    public bool AllowMultiple = false;
}