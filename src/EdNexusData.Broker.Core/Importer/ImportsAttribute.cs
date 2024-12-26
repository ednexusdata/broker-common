using System.Reflection.Metadata;

namespace EdNexusData.Broker.Core.Attributes;

public class ImportsAttribute : Attribute
{
    public Type[] Types { get; }

    public ImportsAttribute(Type[] types)
    {
        Types = types;
    }
}