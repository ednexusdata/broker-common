using Ardalis.Specification;

namespace EdNexusData.Broker.SharedKernel;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
    
}