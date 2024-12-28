using EdNexusData.Broker.Common.EducationOrganizations;
using EdNexusData.Broker.Common.Students;

namespace EdNexusData.Broker.Common.Importer;

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