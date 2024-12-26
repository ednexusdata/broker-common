namespace EdNexusData.Broker.Core.PayloadContentActions;

public class PayloadSettingsContentType
{
    public Guid JobId { get; set; }
    public string PayloadContentType { get; set; } = default!;
    public string? Settings { get; set; }
}