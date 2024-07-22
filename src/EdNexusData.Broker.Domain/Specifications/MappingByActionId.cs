using Ardalis.Specification;

namespace EdNexusData.Broker.Domain.Specifications;

public class MappingByActionId : Specification<Mapping>, ISingleResultSpecification
{
  public MappingByActionId(Guid actionId)
  {
    Query
        .Include(x => x.Action)
        .ThenInclude(x => x!.PayloadContent)
        .Where(req => req.ActionId == actionId)
        .OrderBy(x => x.MappingType);
  }
}