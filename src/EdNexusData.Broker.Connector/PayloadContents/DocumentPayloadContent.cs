namespace EdNexusData.Broker.Connector.Payload.Contents;

public abstract class DocumentPayloadContent : PayloadContent
{   
    public string ContentType { get; set; } = default!;
    public string FileName { get; set; } = default!;
    public new byte[] Content { get; set; } = default!;
}