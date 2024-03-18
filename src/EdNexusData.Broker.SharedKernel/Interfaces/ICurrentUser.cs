namespace EdNexusData.Broker.SharedKernel;

public interface ICurrentUser
{
    public Guid? AuthenticatedUserId();
}