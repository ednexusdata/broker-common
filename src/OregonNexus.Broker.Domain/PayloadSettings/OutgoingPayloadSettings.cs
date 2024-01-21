// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

namespace OregonNexus.Broker.Domain;

public class OutgoingPayloadSettings
{
    public string? StudentLookupConnector { get; set; }
    public List<PayloadSettingsContentType>? PayloadContents { get; set; }
}
