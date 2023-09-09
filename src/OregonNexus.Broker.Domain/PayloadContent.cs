// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

using System.Text.Json;
using System.Xml.Linq;

namespace OregonNexus.Broker.Domain;

public class PayloadContent : BaseEntity, IAggregateRoot
{
    public Guid? IncomingRequestId { get; set; }
    public IncomingRequest? IncomingRequest { get; set; }
    public Guid? OutgoingRequestId { get; set; }
    public OutgoingRequest? OutgoingRequest { get; set; }
    public string? ContentType { get; set; }
    public byte[]? BlobContent { get; set; }
    public JsonDocument? JsonContent { get; set; }
    public XElement? XmlContent { get; set; }
}