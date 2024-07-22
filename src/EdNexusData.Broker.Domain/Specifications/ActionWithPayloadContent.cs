using Ardalis.Specification;
using EdNexusData.Broker.Domain.Worker;

namespace EdNexusData.Broker.Domain.Specifications;

public class ActionWithPayloadContent : Specification<PayloadContentAction>, ISingleResultSpecification
{
  public ActionWithPayloadContent(Guid actionid)
  {
    Query
        .Include(x => x.PayloadContent)
        .Where(x => x.Id == actionid);
  }
}