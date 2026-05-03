namespace EdNexusData.Broker.Common.Lookup;

public class LookupAttribute : Attribute
{
    public Type LookupType { get; }

    /// <summary>
    /// Names of sibling properties this lookup depends on. When any listed property
    /// changes the lookup options should be reloaded with those values as parameters.
    /// </summary>
    public string[]? DependsOn { get; set; }

    public LookupAttribute(Type lookupType)
    {
        LookupType = lookupType;
    }
}