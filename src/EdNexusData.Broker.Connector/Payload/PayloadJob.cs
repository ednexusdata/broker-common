namespace EdNexusData.Broker.Connector;

public abstract class PayloadJob
{
    //public static bool AllowConfiguration = false;
    
    //public static bool AllowMultiple = false;

    public virtual bool AllowConfiguration { get; set; } = false;
    public virtual bool AllowMultiple { get; set; } = false;
    
    public abstract Task<object?> ExecuteAsync(string studentUniqueId);
}