namespace EdNexusData.Broker.Connector.StudentLookup;

public record StudentLookupSearchParameter
{
    public string field { get; set; } = default!;
    public string value { get; set; } = default!;
}