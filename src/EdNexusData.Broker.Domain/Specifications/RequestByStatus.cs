using Ardalis.Specification;

namespace EdNexusData.Broker.Domain.Specifications;

public class RequestsReadyForProcessing : Specification<Request>, ISingleResultSpecification
{
  public RequestsReadyForProcessing()
  {
    var requestStatuses = new RequestStatus[] { RequestStatus.WaitingToSend, RequestStatus.WaitingToLoad, RequestStatus.WaitingToPrepare, RequestStatus.WaitingToImport };

    Query
        .Include(i => i.EducationOrganization)
        .Where(req => requestStatuses.Contains(req.RequestStatus));
  }
}