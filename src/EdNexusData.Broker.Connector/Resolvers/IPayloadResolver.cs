using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.Resolvers;

public interface IPayloadResolver
{
    public Task<IncomingPayloadSettings> FetchIncomingPayloadSettingsAsync<T>(Guid educationOrganizationId) where T : Payload;

    public Task<OutgoingPayloadSettings> FetchOutgoingPayloadSettingsAsync<T>(Guid educationOrganizationId) where T : Payload;
}