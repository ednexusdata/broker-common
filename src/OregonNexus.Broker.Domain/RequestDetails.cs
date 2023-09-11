// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

using System.Reflection;

namespace OregonNexus.Broker.Domain;

public class RequestDetails
{
    public DateTime CreateDate { get; set; } = DateTime.UtcNow;

    public string? PayloadType { get; set; } = typeof(object).FullName;

    public Dictionary<string, object> Details { get; set; } = new Dictionary<string, object>();
}