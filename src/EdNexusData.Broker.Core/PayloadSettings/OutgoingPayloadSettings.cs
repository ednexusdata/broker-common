using EdNexusData.Broker.Core.PayloadContentActions;

namespace EdNexusData.Broker.Core.PayloadSettings;

public class OutgoingPayloadSettings
{
    public string? StudentLookupConnector { get; set; }
    public List<PayloadSettingsContentType>? PayloadContents { get; set; }
}