using Ardalis.Specification;

namespace OregonNexus.Broker.Domain.Specifications;

public class PayloadSettingsByNameAndEdOrgIdSpec : Specification<EducationOrganizationPayloadSettings>
{
  public PayloadSettingsByNameAndEdOrgIdSpec(string payload, Guid educationOrganizationId)
  {
    Query
        .Where(x => x.Payload == payload 
            && x.EducationOrganizationId == educationOrganizationId);
  }
}