namespace OregonNexus.Broker.Connector;

public class LookupAttribute : Attribute
{
    public Type LookupType { get; }

    public LookupAttribute(Type lookupType)
    {
        LookupType = lookupType;
    }
}