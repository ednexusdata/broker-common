using EdNexusData.Broker.Common.Payloads;

namespace EdNexusData.Broker.Common.PayloadSettings;

public interface IPayloadResolver
{
    public Task<IncomingPayloadSettings> FetchIncomingPayloadSettingsAsync<T>(Guid educationOrganizationId) where T : Payload;

    public Task<OutgoingPayloadSettings> FetchOutgoingPayloadSettingsAsync<T>(Guid educationOrganizationId) where T : Payload;
}