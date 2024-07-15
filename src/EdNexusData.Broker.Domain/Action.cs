using System.Text.Json;

namespace EdNexusData.Broker.Domain;

public class Action : BaseEntity, IAggregateRoot
{
    public Guid? PayloadContentId { get; set; }
    public PayloadContent? PayloadContent { get; set; }
    public string? PayloadContentActionType { get; set; }
    public Guid? ActiveMappingId { get; set; }
    public Mapping? ActiveMapping { get; set; }
    public JsonDocument? Settings { get; set; }
    public bool Process { get; set; } = false;
    public List<Mapping>? Mappings { get; set; }
}
