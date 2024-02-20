using System.Reflection.Metadata;

namespace OregonNexus.Broker.Connector.Attributes;

public class ImportsAttribute : Attribute
{
    public Type[] Types { get; }

    public ImportsAttribute(Type[] types)
    {
        Types = types;
    }
}