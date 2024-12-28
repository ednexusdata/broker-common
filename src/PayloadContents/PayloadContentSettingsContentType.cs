namespace EdNexusData.Broker.Common.PayloadContentActions;

public class PayloadSettingsContentType
{
    public Guid JobId { get; set; }
    public string PayloadContentType { get; set; } = default!;
    public string? Settings { get; set; }
}