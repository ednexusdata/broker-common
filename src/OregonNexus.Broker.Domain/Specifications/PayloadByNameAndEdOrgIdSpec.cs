using Ardalis.Specification;

namespace OregonNexus.Broker.Domain.Specifications;

public class PayloadByNameAndEdOrgIdSpec : Specification<EducationOrganizationPayloadSettings>
{
  public PayloadByNameAndEdOrgIdSpec(string payloadName, Guid educationOrganizationId)
  {
    Query
        .Where(x => x.Payload == payloadName && x.EducationOrganizationId == educationOrganizationId);
  }
}