namespace EdNexusData.Broker.Core.Mapping;

public class DisplayInTableAttribute : Attribute
{
    public byte Order = 0;

    public DisplayInTableAttribute(byte order = 0)
    {
        Order = order;
    }
}