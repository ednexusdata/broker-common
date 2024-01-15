using Ardalis.Specification;

namespace OregonNexus.Broker.Domain.Specifications;

public class RequestsReadyForProcessing : Specification<Request>, ISingleResultSpecification
{
  public RequestsReadyForProcessing()
  {
    var requestStatuses = new RequestStatus[] { RequestStatus.WaitingToSend, RequestStatus.WaitingToImport };

    Query
        .Where(req => requestStatuses.Contains(req.RequestStatus) && req.WorkerInstance == null);
  }
}