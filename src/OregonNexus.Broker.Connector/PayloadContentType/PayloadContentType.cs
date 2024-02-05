namespace OregonNexus.Broker.Connector.PayloadContentTypes;

public abstract class PayloadContentType
{
    public abstract string ContentType { get; }
    public virtual string Content { get; set; } = default!;

    public bool AllowMultiple = false;
}