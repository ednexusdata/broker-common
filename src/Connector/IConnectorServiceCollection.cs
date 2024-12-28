using Microsoft.Extensions.DependencyInjection;

namespace EdNexusData.Broker.Common.Connector;

public interface IConnectorServiceCollection
{
    static abstract IServiceCollection AddDependencies(IServiceCollection services);
}