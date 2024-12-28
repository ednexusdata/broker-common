namespace EdNexusData.Broker.Common.PayloadContents;

public abstract class DataPayloadContent : PayloadContent
{   
    public object? Content { get; set; }
    public abstract PayloadContentSchema Schema { get; }
}