using Ardalis.Specification;

namespace EdNexusData.Broker.Domain.Specifications;

public class MappingByRequestId : Specification<Mapping>, ISingleResultSpecification
{
  public MappingByRequestId(Guid RequestId)
  {
    Query
        .Include(x => x.Action)
        .ThenInclude(x => x!.PayloadContent)
        .ThenInclude(x => x!.Request)
        .Where(y => y.Action!.PayloadContent!.RequestId == RequestId)
        .OrderBy(x => x.MappingType);
  }
}