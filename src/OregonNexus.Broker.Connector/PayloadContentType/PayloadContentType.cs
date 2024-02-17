using OregonNexus.Broker.Domain;

namespace OregonNexus.Broker.Connector.PayloadContentTypes;

public abstract class PayloadContentType
{
    public abstract PayloadContentSchema Schema { get; }
    public object? Content { get; set; }
    public bool AllowMultiple = false;
}