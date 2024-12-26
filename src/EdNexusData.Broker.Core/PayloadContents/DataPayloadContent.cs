namespace EdNexusData.Broker.Core.PayloadContents;

public abstract class DataPayloadContent : PayloadContent
{   
    public object? Content { get; set; }
    public abstract PayloadContentSchema Schema { get; }
}