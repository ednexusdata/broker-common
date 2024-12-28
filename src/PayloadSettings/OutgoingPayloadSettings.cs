using EdNexusData.Broker.Common.PayloadContentActions;

namespace EdNexusData.Broker.Common.PayloadSettings;

public class OutgoingPayloadSettings
{
    public string? StudentLookupConnector { get; set; }
    public List<PayloadSettingsContentType>? PayloadContents { get; set; }
}