namespace EdNexusData.Broker.Common.PayloadContentActions;

public class ProcessesTransformerAttribute : Attribute
{
    public Type[] ProcessesTransformerTypes { get; }

    public ProcessesTransformerAttribute(params Type[] transformerTypes)
    {
        ProcessesTransformerTypes = transformerTypes;
    }
}