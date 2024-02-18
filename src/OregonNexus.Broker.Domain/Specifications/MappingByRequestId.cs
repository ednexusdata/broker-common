using Ardalis.Specification;

namespace OregonNexus.Broker.Domain.Specifications;

public class MappingByRequestId : Specification<Mapping>, ISingleResultSpecification
{
  public MappingByRequestId(Guid requestId)
  {
    Query
        .Where(req => req.RequestId == requestId)
        .OrderBy(x => x.MappingType);
  }
}