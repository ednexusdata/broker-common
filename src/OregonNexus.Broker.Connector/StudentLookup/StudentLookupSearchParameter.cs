using System.Reflection;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OregonNexus.Broker.Connector.Payload;
using OregonNexus.Broker.Connector.PayloadContentTypes;
using OregonNexus.Broker.Domain;
using OregonNexus.Broker.Domain.Specifications;
using OregonNexus.Broker.SharedKernel;

namespace OregonNexus.Broker.Connector.StudentLookup;

public record StudentLookupSearchParameter
{
    public string field { get; set; } = default!;
    public string value { get; set; } = default!;
}