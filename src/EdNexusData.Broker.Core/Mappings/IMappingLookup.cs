using Microsoft.AspNetCore.Mvc.Rendering;

namespace EdNexusData.Broker.Core.Mappings;

public interface IMappingLookup
{
    public Task<List<SelectListItem>> SelectListAsync();
}