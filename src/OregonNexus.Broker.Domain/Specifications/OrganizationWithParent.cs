using Ardalis.Specification;

namespace OregonNexus.Broker.Domain.Specifications;

public class OrganizationByIdWithParentSpec : Specification<EducationOrganization>, ISingleResultSpecification
{
  public OrganizationByIdWithParentSpec(Guid educationOrganizationId)
  {
    Query
        .Include(edOrg => edOrg.ParentOrganization)
        .Where(edOrg => edOrg.Id == educationOrganizationId);
  }
}