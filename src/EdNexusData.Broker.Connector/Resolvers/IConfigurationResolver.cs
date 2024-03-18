namespace EdNexusData.Broker.Connector.Resolvers;

public interface IConfigurationResolver
{
    public Task<T> FetchConnectorSettingsAsync<T>();

    public Task<T> FetchConnectorSettingsAsync<T>(string districtNumber);
}