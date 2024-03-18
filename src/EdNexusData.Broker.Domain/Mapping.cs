using System.Text.Json;

namespace EdNexusData.Broker.Domain;

public class Mapping : BaseEntity, IAggregateRoot
{
    public Guid? RequestId { get; set; }
    public Request? Request { get; set; }
    public PayloadContentSchema? OriginalSchema { get; set; }
    public string? MappingType { get; set; }
    public StudentAttributes? StudentAttributes { get; set; }
    public JsonDocument? SourceMapping { get; set; }
    public JsonDocument? DestinationMapping { get; set; }
}