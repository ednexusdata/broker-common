using EdNexusData.Broker.Common.EducationOrganizations;
using EdNexusData.Broker.Common.Jobs;
using EdNexusData.Broker.Common.Requests;
using EdNexusData.Broker.Common.Students;

namespace EdNexusData.Broker.Common.Importer;

public interface IImporter
{
    
    public void Prepare(
        Type typeOfObjectsToImport, 
        object objectsToImport, 
        Student student,
        EducationOrganization educationOrganization,
        Manifest manifest,
        IJobStatusService jobStatusService
    );

    public Task PrepareAsync(
        Type typeOfObjectsToImport, 
        object objectsToImport, 
        Student student,
        EducationOrganization educationOrganization,
        Manifest manifest,
        IJobStatusService jobStatusService
    );

    public Task<object> ImportAsync(IJobStatusService jobStatusService);
}