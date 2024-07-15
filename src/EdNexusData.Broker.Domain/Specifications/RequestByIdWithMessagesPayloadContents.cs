using Ardalis.Specification;

namespace EdNexusData.Broker.Domain.Specifications;

public class RequestByIdWithMessagesPayloadContents : Specification<Request>, ISingleResultSpecification
{
  public RequestByIdWithMessagesPayloadContents(Guid requestId)
  {
    Query
        .Include(x => x.EducationOrganization)
        .Include(x => x.EducationOrganization!.ParentOrganization)
        .Include(x => x.Messages!.OrderByDescending(y => y.MessageTimestamp))!
        .ThenInclude(x => x.PayloadContents!.OrderBy(y => y.FileName))
        .ThenInclude(x => x.Actions)
        .Where(req => req.Id == requestId);
  }
}