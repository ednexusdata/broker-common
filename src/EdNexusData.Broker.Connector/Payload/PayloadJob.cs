namespace EdNexusData.Broker.Connector;

public abstract class PayloadJob
{
    public bool AllowMultiple = false;
    
    public abstract Task<object?> ExecuteAsync(string studentUniqueId);
}