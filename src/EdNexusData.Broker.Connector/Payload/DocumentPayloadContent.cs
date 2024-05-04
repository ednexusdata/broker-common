namespace EdNexusData.Broker.Connector;

public abstract class DocumentPayloadContent : PayloadContent
{   
    public string ContentType { get; set; } = default!;
    public string FileName { get; set; } = default!;
    public byte[] Content { get; set; } = default!;
}