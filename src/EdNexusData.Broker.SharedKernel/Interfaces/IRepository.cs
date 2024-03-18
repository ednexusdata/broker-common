using Ardalis.Specification;

namespace EdNexusData.Broker.SharedKernel;

public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
}