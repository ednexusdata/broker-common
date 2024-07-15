using Ardalis.Specification;

namespace EdNexusData.Broker.Domain.Specifications;

public class MappingByPayloadContentId : Specification<Mapping>, ISingleResultSpecification
{
  public MappingByPayloadContentId(Guid payloadContentId)
  {
    Query
        .Include(x => x.Action)
        .Where(req => req.Action!.PayloadContentId == payloadContentId)
        .OrderBy(x => x.MappingType);
  }
}