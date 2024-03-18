
namespace EdNexusData.Broker.Connector.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class JobAttribute : Attribute
{
    public Type JobType;

    public JobAttribute(Type jobType)
    {
        JobType = jobType;
    }
}