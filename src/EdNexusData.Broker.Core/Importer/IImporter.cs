using EdNexusData.Broker.Core.EducationOrganizations;
using EdNexusData.Broker.Core.Students;

namespace EdNexusData.Broker.Core.Importer;

public interface IImporter
{
    
    public void Prepare(
        Type typeOfObjectsToImport, 
        object objectsToImport, 
        Student student,
        EducationOrganization educationOrganization,
        Manifest manifest
    );

    public Task PrepareAsync(
        Type typeOfObjectsToImport, 
        object objectsToImport, 
        Student student,
        EducationOrganization educationOrganization,
        Manifest manifest
    );

    public Task<object> ImportAsync();
}