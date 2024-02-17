using Ardalis.Specification;

namespace OregonNexus.Broker.Domain.Specifications;

public class PayloadContentsByRequestIdAndFileName : Specification<PayloadContent>, ISingleResultSpecification
{
  public PayloadContentsByRequestIdAndFileName(Guid requestId, string fileName)
  {
    Query
        .Where(req => req.RequestId == requestId && req.FileName == fileName);
  }
}