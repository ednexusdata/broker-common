using EdNexusData.Broker.Common.PayloadContentActions;

namespace EdNexusData.Broker.Common.PayloadSettings;

public class IncomingPayloadSettings
{
    public string? StudentInformationSystem { get; set; }
    public List<PayloadSettingsContentType>? PayloadContents { get; set; }
}