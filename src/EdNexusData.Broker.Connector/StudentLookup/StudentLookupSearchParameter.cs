using System.Reflection;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using EdNexusData.Broker.Connector.Payload;
using EdNexusData.Broker.Connector.PayloadContentTypes;
using EdNexusData.Broker.Domain;
using EdNexusData.Broker.Domain.Specifications;
using EdNexusData.Broker.SharedKernel;

namespace EdNexusData.Broker.Connector.StudentLookup;

public record StudentLookupSearchParameter
{
    public string field { get; set; } = default!;
    public string value { get; set; } = default!;
}