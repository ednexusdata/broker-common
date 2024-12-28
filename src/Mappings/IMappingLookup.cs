using Microsoft.AspNetCore.Mvc.Rendering;

namespace EdNexusData.Broker.Common.Mappings;

public interface IMappingLookup
{
    public Task<List<SelectListItem>> SelectListAsync();
}