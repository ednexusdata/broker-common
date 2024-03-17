using Ardalis.Specification;

namespace OregonNexus.Broker.Domain.Specifications;

public class UserWithUserRolesByUserSpec : Specification<User>
{
  public UserWithUserRolesByUserSpec(Guid UserId)
  {
    Query
        .Include(x => x.UserRoles)!
        .ThenInclude(x => x.EducationOrganization)
        .Where(user => user.Id == UserId);
  }
}