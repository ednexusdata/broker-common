using Microsoft.AspNetCore.Mvc.Rendering;

namespace EdNexusData.Broker.Common.Mappings;

public interface IMappingLookup
{
    Task<List<SelectListItem>> SelectListAsync();

    /// <summary>
    /// Returns a filtered list based on values selected in dependent properties.
    /// Defaults to the unfiltered list; override to implement filtering.
    /// </summary>
    Task<List<SelectListItem>> SelectListAsync(Dictionary<string, string?> dependentValues)
        => SelectListAsync();
}