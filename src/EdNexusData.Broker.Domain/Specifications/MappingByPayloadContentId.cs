using Ardalis.Specification;

namespace EdNexusData.Broker.Domain.Specifications;

public class MappingByPayloadContentId : Specification<Mapping>, ISingleResultSpecification
{
  public MappingByPayloadContentId(Guid payloadContentId)
  {
    Query
        .Where(req => req.PayloadContentId == payloadContentId)
        .OrderBy(x => x.MappingType);
  }
}