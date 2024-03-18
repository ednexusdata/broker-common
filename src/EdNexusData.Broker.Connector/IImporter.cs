using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector;

public interface IImporter
{
    
    public void Prepare(
        Type typeOfObjectsToImport, 
        object objectsToImport, 
        Domain.Student student, 
        EducationOrganization educationOrganization,
        Manifest manifest
    );

    public Task PrepareAsync(
        Type typeOfObjectsToImport, 
        object objectsToImport, 
        Domain.Student student, 
        EducationOrganization educationOrganization,
        Manifest manifest
    );

    public Task<object> ImportAsync();
}