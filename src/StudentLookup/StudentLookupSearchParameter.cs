namespace EdNexusData.Broker.Common.StudentLookup;

public record StudentLookupSearchParameter
{
    public string field { get; set; } = default!;
    public string value { get; set; } = default!;
}