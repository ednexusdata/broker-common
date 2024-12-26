using Microsoft.Extensions.DependencyInjection;

namespace EdNexusData.Broker.Core.Connector;

public interface IConnectorServiceCollection
{
    static abstract IServiceCollection AddDependencies(IServiceCollection services);
}