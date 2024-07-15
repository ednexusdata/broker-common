using Ardalis.Specification;

namespace EdNexusData.Broker.Domain.Specifications;

public class MappingWithPayloadContent : Specification<Mapping>, ISingleResultSpecification
{
  public MappingWithPayloadContent(Guid id)
  {
    Query
        .Include(x => x.Action)
        .ThenInclude(x => x!.PayloadContent)
        .ThenInclude(x => x!.Request)
        .Where(x => x.Id == id)
        .OrderBy(x => x.MappingType);
  }
}