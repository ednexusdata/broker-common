using Microsoft.AspNetCore.Mvc.Rendering;

namespace EdNexusData.Broker.Core.Mapping;

public interface IMappingLookup
{
    public Task<List<SelectListItem>> SelectListAsync();
}