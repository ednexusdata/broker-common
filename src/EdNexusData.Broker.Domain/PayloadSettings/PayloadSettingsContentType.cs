// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

using System.Text.Json;

namespace EdNexusData.Broker.Domain;

public class PayloadSettingsContentType
{
    public string PayloadContentType { get; set; } = default!;
    public string? Settings { get; set; }
}
