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

namespace EdNexusData.Broker.Connector.Resolvers;

public interface IPayloadResolver
{
    public Task<IncomingPayloadSettings> FetchIncomingPayloadSettingsAsync<T>(Guid educationOrganizationId) where T : IPayload;

    public Task<OutgoingPayloadSettings> FetchOutgoingPayloadSettingsAsync<T>(Guid educationOrganizationId) where T : IPayload;
}