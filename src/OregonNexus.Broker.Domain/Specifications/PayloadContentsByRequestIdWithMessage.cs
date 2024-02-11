using Ardalis.Specification;

namespace OregonNexus.Broker.Domain.Specifications;

public class PayloadContentsByRequestIdWithMessage : Specification<PayloadContent>, ISingleResultSpecification
{
  public PayloadContentsByRequestIdWithMessage(Guid requestId)
  {
    Query
        .Include(x => x.Message)
        .Where(req => req.RequestId == requestId)
        .OrderBy(x => x.FileName);
  }
}