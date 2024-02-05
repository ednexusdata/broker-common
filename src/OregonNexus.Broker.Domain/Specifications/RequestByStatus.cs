using Ardalis.Specification;

namespace OregonNexus.Broker.Domain.Specifications;

public class RequestsReadyForProcessing : Specification<Request>, ISingleResultSpecification
{
  public RequestsReadyForProcessing()
  {
    var requestStatuses = new RequestStatus[] { RequestStatus.WaitingToSend, RequestStatus.WaitingToLoad, RequestStatus.WaitingToImport };

    Query
        .Include(i => i.EducationOrganization)
        .Where(req => requestStatuses.Contains(req.RequestStatus));
  }
}