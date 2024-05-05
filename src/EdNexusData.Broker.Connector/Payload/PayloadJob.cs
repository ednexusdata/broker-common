namespace EdNexusData.Broker.Connector;

public abstract class PayloadJob
{
    public static bool AllowConfiguration = false;
    
    public static bool AllowMultiple = false;
    
    public abstract Task<object?> ExecuteAsync(string studentUniqueId);
}