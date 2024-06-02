namespace EdNexusData.Broker.Connector.PayloadContentActions;

public interface IPayloadContentAction
{
    public static string DisplayName { get; } = default!;
    
    public Task<bool> ExecuteAsync();
}