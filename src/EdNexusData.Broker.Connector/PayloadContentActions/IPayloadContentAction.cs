using EdNexusData.Broker.Connector.Student;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.PayloadContentActions;

public interface IPayloadContentAction
{
    public static string DisplayName { get; } = default!;
    
    public Task<bool> ExecuteAsync(object mapping, 
        PayloadContentAction payloadContentAction, 
        IStudent student, 
        Domain.Student brokerStudent, 
        EducationOrganization educationOrganization
    );
}