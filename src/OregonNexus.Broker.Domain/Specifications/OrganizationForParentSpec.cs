using Ardalis.Specification;

namespace OregonNexus.Broker.Domain.Specifications;

public class OrganizationByParentSpec : Specification<EducationOrganization>, ISingleResultSpecification
{
  public OrganizationByParentSpec(Guid parentOrganizationId)
  {
    Query
        .Include(x => x.ParentOrganization)
        .Where(org => org.ParentOrganizationId == parentOrganizationId 
                   && org.EducationOrganizationType == EducationOrganizationType.School);
  }
}