// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com
using System.Text.Json;

namespace OregonNexus.Broker.Domain;

public class Message : BaseEntity, IAggregateRoot
{
    public Guid RequestId { get; set; }
    public Request? Request { get; set; }
    public RequestResponse RequestResponse { get; set; } = RequestResponse.Request;
    public DateTime? MessageTimestamp { get; set; }
    public JsonDocument? MessageContents { get; set; }
    public JsonDocument? TransmissionDetails { get; set; }
}