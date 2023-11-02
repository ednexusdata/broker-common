namespace OregonNexus.Broker.Connector.PayloadContentTypes;

public abstract class PayloadContentType
{
    public abstract string ContentType { get; }
    public abstract string Content { get; set; }
}