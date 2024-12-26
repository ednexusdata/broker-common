using System.Text.Json;
using EdNexusData.Broker.Core.PayloadContentActions;
using EdNexusData.Broker.Core.PayloadContents;
using EdNexusData.Broker.Core.Students;

namespace EdNexusData.Broker.Core.Mappings;

public class Mapping
{
    public Guid Id { get; set; }
    public Guid? PayloadContentActionId { get; set; }
    public PayloadContentAction? PayloadContentAction { get; set; }
    public PayloadContentAction? PrimaryPayloadContentAction { get; set; }
    public PayloadContentSchema? OriginalSchema { get; set; }
    public string? MappingType { get; set; }
    public StudentAttributes? StudentAttributes { get; set; }
    public JsonDocument? JsonSourceMapping { get; set; }
    public JsonDocument? JsonInitialMapping { get; set; }
    public JsonDocument? JsonDestinationMapping { get; set; }
    public byte Version { get; set; } = 1;
}