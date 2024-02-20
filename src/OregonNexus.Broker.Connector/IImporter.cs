using OregonNexus.Broker.Domain;

namespace OregonNexus.Broker.Connector;

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