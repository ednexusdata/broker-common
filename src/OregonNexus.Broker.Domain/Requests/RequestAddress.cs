// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com
using System.Text.Json;
using Ardalis.GuardClauses;

namespace OregonNexus.Broker.Domain;

public class RequestAddress
{
    public string? District { get; set; } = default!;
    public string? School { get; set; } = default!;
    public string? Email { get; set; } = default!;
    public string? StreetNumberName { get; set; } = default!;
    public string? City { get; set; } = default!;
    public string? StateAbbreviation { get; set; } = default!;
    public string? PostalCode { get; set; } = default!;
}