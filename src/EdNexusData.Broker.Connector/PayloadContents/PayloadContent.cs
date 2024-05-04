namespace EdNexusData.Broker.Connector.Payload.Contents;

public abstract class PayloadContent
{
    public object? Content { get; set; }
    
    public bool AllowMultiple = false;
}