using Microsoft.AspNetCore.Mvc.Rendering;

namespace EdNexusData.Broker.Connector;

public interface IMappingLookup
{
    public Task<List<SelectListItem>> SelectListAsync();
}