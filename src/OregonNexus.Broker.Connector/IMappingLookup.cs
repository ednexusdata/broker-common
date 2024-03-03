using Microsoft.AspNetCore.Mvc.Rendering;

namespace OregonNexus.Broker.Connector;

public interface IMappingLookup
{
    public Task<List<SelectListItem>> SelectListAsync();
}