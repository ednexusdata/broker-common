namespace EdNexusData.Broker.Common.Lookup;

public class LookupAttribute : Attribute
{
    public Type LookupType { get; }

    public LookupAttribute(Type lookupType)
    {
        LookupType = lookupType;
    }
}