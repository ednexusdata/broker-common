using EdNexusData.Broker.Core.EducationOrganizations;
using EdNexusData.Broker.Core.Students;

namespace EdNexusData.Broker.Core.PayloadContentActions;

public interface IPayloadContentAction
{
    public static string DisplayName { get; } = default!;
    
    public Task<(bool, object)> ExecuteAsync(object mapping, 
        PayloadContentAction payloadContentAction, 
        IStudent student, 
        Student brokerStudent,
        EducationOrganization educationOrganization
    );
}