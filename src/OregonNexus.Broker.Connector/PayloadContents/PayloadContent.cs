using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.PayloadContents;

public abstract class PayloadContent<T> where T : PayloadContentType
{   
    public abstract Task<T> ExecuteAsync(); 
}