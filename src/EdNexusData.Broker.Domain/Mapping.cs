using System.Text.Json;

namespace EdNexusData.Broker.Domain;

public class Mapping : BaseEntity, IAggregateRoot
{
    public Guid? ActionId { get; set; }
    public Action? Action { get; set; }
    public PayloadContentSchema? OriginalSchema { get; set; }
    public string? MappingType { get; set; }
    public StudentAttributes? StudentAttributes { get; set; }
    public JsonDocument? JsonSourceMapping { get; set; }
    public JsonDocument? JsonDestinationMapping { get; set; }
    public byte Version { get; set; } = 1;
}
