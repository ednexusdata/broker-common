using EdNexusData.Broker.Core.Payloads;

namespace EdNexusData.Broker.Core.PayloadSettings;

public interface IPayloadResolver
{
    public Task<IncomingPayloadSettings> FetchIncomingPayloadSettingsAsync<T>(Guid educationOrganizationId) where T : Payload;

    public Task<OutgoingPayloadSettings> FetchOutgoingPayloadSettingsAsync<T>(Guid educationOrganizationId) where T : Payload;
}