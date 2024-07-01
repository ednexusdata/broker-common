using EdNexusData.Broker.Domain.Worker;

namespace EdNexusData.Broker.Connector;

public interface IJob
{
    public Task ProcessAsync(Job jobRecord);
}