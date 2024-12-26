using EdNexusData.Broker.Core.Student;

namespace EdNexusData.Broker.Core.PayloadContentActions;

public interface IPayloadContentAction
{
    public static string DisplayName { get; } = default!;
    
    public Task<(bool, object)> ExecuteAsync(object mapping, 
        PayloadContentAction payloadContentAction, 
        IStudent student, 
        Contracts.Student brokerStudent,
        EducationOrganization.EducationOrganization educationOrganization
    );
}