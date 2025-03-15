namespace EdNexusData.Broker.Common.Requests;

public class Manifest
{
    public string? RequestType { get; set; }
    public string? MessageType { get; set; }
    public RequestAddress? From { get; set; }
    public RequestAddress? To { get; set; }
    public string? Note { get; set; }

    public List<ManifestContent>? Contents { get; set; } = new List<ManifestContent>();
}