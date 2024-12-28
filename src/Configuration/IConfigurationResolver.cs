namespace EdNexusData.Broker.Common.Configuration;

public interface IConfigurationResolver
{
    public Task<T> FetchConnectorSettingsAsync<T>();

    public Task<T> FetchConnectorSettingsAsync<T>(string districtNumber);
}