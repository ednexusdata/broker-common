using EdNexusData.Broker.Core.EducationOrganization;

namespace EdNexusData.Broker.Core.Importer;

public interface IImporter
{
    
    public void Prepare(
        Type typeOfObjectsToImport, 
        object objectsToImport, 
        Student.Student student,
        EducationOrganization.EducationOrganization educationOrganization,
        Manifest manifest
    );

    public Task PrepareAsync(
        Type typeOfObjectsToImport, 
        object objectsToImport, 
        Student.Student student,
        EducationOrganization.EducationOrganization educationOrganization,
        Manifest manifest
    );

    public Task<object> ImportAsync();
}