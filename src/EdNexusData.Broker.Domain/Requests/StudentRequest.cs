// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com
using System.Text.Json;
using System.Text.Json.Serialization;
using Ardalis.GuardClauses;

namespace EdNexusData.Broker.Domain;

public class StudentRequest
{
    [JsonPropertyName("EdNexusData.Broker.Domain.Student")]
    public Student? Student { get; set; }

    public Dictionary<string, object>? Connectors { get; set; }
}