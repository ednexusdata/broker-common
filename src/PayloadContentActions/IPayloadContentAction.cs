using EdNexusData.Broker.Common.EducationOrganizations;
using EdNexusData.Broker.Common.Students;

namespace EdNexusData.Broker.Common.PayloadContentActions;

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