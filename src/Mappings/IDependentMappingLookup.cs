using Microsoft.AspNetCore.Mvc.Rendering;

namespace EdNexusData.Broker.Common.Mappings;

/// <summary>
/// Marker interface for lookups whose options are meaningless without values from
/// one or more sibling properties declared via <see cref="EdNexusData.Broker.Common.Lookup.LookupAttribute.DependsOn"/>.
///
/// Implementors only need to provide:
///   Task&lt;List&lt;SelectListItem&gt;&gt; SelectListAsync(Dictionary&lt;string, string?&gt; dependentValues)
///
/// The parameterless SelectListAsync() returns an empty list automatically, because
/// there is nothing useful to return without the parent values.
/// </summary>
public interface IDependentMappingLookup : IMappingLookup
{
    // Parameterless call has no parent context — return empty rather than
    // forcing every implementor to write a meaningless stub.
    Task<List<SelectListItem>> IMappingLookup.SelectListAsync()
        => Task.FromResult(new List<SelectListItem>());

    // Route the base-interface parameterized default to our abstract overload
    // so that callers holding an IMappingLookup reference still hit the right impl.
    Task<List<SelectListItem>> IMappingLookup.SelectListAsync(Dictionary<string, string?> dependentValues)
        => SelectListAsync(dependentValues);

    /// <summary>
    /// Returns options filtered by the provided parent property values.
    /// Keys are the property names listed in <see cref="EdNexusData.Broker.Common.Lookup.LookupAttribute.DependsOn"/>.
    /// </summary>
    new Task<List<SelectListItem>> SelectListAsync(Dictionary<string, string?> dependentValues);
}
