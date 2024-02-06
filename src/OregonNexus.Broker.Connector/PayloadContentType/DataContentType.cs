using System.Text.Json;
using System.Xml;

namespace OregonNexus.Broker.Connector.PayloadContentTypes;

public abstract class DataContentType : PayloadContentType
{
    public abstract string Schema { get; }
    public abstract string SchemaVersion { get; }
    public virtual JsonDocument? JsonContent { get; set; }
    public virtual XmlDocument? XmlContent { get; set; }
}