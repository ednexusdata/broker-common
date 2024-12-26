namespace EdNexusData.Broker.Core.Mappings;

public class DisplayInTableAttribute : Attribute
{
    public byte Order = 0;

    public DisplayInTableAttribute(byte order = 0)
    {
        Order = order;
    }
}