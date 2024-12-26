using EdNexusData.Broker.Core.PayloadContentActions;

namespace EdNexusData.Broker.Core.PayloadSettings;

public class IncomingPayloadSettings
{
    public string? StudentInformationSystem { get; set; }
    public List<PayloadSettingsContentType>? PayloadContents { get; set; }
}