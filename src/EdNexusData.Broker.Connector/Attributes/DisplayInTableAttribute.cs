namespace EdNexusData.Broker.Connector.Attributes;

public class DisplayInTableAttribute : Attribute
{
    public byte Order = 0;

    public DisplayInTableAttribute(byte order = 0)
    {
        Order = order;
    }
}