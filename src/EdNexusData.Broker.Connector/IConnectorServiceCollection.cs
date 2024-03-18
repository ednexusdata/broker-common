using Microsoft.Extensions.DependencyInjection;

namespace EdNexusData.Broker.Connector;

public interface IConnectorServiceCollection
{
    static abstract IServiceCollection AddDependencies(IServiceCollection services);

}