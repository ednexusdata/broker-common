using OregonNexus.Broker.SharedKernel;
using OregonNexus.Broker.Domain;
using OregonNexus.Broker.Domain.Specifications;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using System.Dynamic;

namespace OregonNexus.Broker.Connector.Payload;

public class PayloadSerializer
{
    private readonly IRepository<EducationOrganizationPayloadSettings> _repo;
    private readonly IServiceProvider _serviceProvider;

    public PayloadSerializer(IRepository<EducationOrganizationPayloadSettings> repo, IServiceProvider serviceProvider)
    {
        _repo = repo;
        _serviceProvider = serviceProvider;
    }

    public async Task<IPayload> DeseralizeAsync(
        Type connectorConfigType,
        PayloadDirection payloadDirection,
        Guid focusEducationOrganization)
    {
        var iPayloadModel = ActivatorUtilities.CreateInstance(_serviceProvider, connectorConfigType) as IPayload;
        var objTypeName = iPayloadModel.GetType().FullName;

        // Get existing object
        if (connectorConfigType.Assembly.GetName().Name != null)
        {
            var connectorSpec = new PayloadByNameAndEdOrgIdSpec(
                connectorConfigType?.FullName,
                payloadDirection,
                focusEducationOrganization);
            var repoConnectorSettings = await _repo.FirstOrDefaultAsync(connectorSpec);
            if (repoConnectorSettings is not null)
            {
                var configSettings = Newtonsoft.Json.Linq.JObject.Parse(repoConnectorSettings.Settings.RootElement.GetRawText());

                //var configSettingsObj = configSettings[objTypeName];

                foreach (var prop in iPayloadModel!.GetType().GetProperties())
                {
                    // Check if prop in configSettings
                    var value = configSettings.Value<string>(prop.Name);
                    if (value is not null)
                    {
                        prop.SetValue(iPayloadModel, value);
                    }
                }
            }
        }
        return iPayloadModel!;
    }

    public async Task<IPayload> SerializeAndSaveAsync(
        IPayload obj,
        PayloadDirection payloadDirection,
        Guid focusEducationOrganization)
    {
        var repoConnectorSettings = new EducationOrganizationPayloadSettings();

        var objType = obj.GetType();
        var objTypeName = objType.FullName;
        var objAssemblyName = objType.Assembly.GetName().Name!;

        // Get existing record, if there is one
        var connectorSpec = new PayloadByNameAndEdOrgIdSpec(
            objAssemblyName,
            payloadDirection,
            focusEducationOrganization);

        var prevRepoConnectorSettings = await _repo.FirstOrDefaultAsync(connectorSpec);
        if (prevRepoConnectorSettings is not null)
        {
            repoConnectorSettings = prevRepoConnectorSettings;
        }

        dynamic objWrapper = new ExpandoObject();
        ((IDictionary<string, object>)objWrapper)[objTypeName] = obj;

        var seralizedIConfigModel = JsonSerializer.SerializeToDocument<dynamic>(objWrapper);
        repoConnectorSettings.Settings = seralizedIConfigModel;

        if (objAssemblyName != null && repoConnectorSettings.Id != Guid.Empty)
        {
            repoConnectorSettings.PayloadDirection = payloadDirection;
            await _repo.UpdateAsync(repoConnectorSettings);
        }
        else
        {
            repoConnectorSettings.PayloadDirection = payloadDirection;
            repoConnectorSettings.EducationOrganizationId = focusEducationOrganization;
            repoConnectorSettings.Payload = objAssemblyName;
            await _repo.AddAsync(repoConnectorSettings);
        }

        return obj;
    }
}