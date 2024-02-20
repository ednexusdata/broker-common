namespace OregonNexus.Broker.Connector;

public class MapsFromAttribute : Attribute
{
    public string Schema { get; }
    public string SchemaVersion { get; }

    public MapsFromAttribute(string schema, string schemaVersion)
    {
        Schema = schema;
        SchemaVersion = schemaVersion;
    }
}