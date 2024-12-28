using System.Text.Json;
using EdNexusData.Broker.Common.Mappings;
using EdNexusData.Broker.Common.PayloadContents;

namespace EdNexusData.Broker.Common.PayloadContentActions;

public class PayloadContentAction
{
    public Guid Id { get; set; }
    public Guid? PayloadContentId { get; set; }
    public PayloadContent? PayloadContent { get; set; }
    public string? PayloadContentActionType { get; set; }
    public Guid? ActiveMappingId { get; set; }
    public Mapping? ActiveMapping { get; set; }
    public JsonDocument? Settings { get; set; }
    public bool Process { get; set; } = false;
    public List<Mapping>? Mappings { get; set; }
    public PayloadContentActionStatus PayloadContentActionStatus { get; set; } = PayloadContentActionStatus.Ready;
    public string? ProcessState {get; set; }
}