// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

namespace OregonNexus.Broker.Domain;

public class OutgoingPayloadSettings
{
    public string? PrimaryDataConnector { get; set; }
    public List<PayloadSettingsContentType>? PayloadContents { get; set; }
}
