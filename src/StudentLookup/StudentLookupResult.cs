namespace EdNexusData.Broker.Common.StudentLookup;

public record StudentLookupResult
{
    public string StudentId { get; set; } = default!;
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? Gender { get; set; }
    public string? Grade { get; set; }
    public DateOnly? BirthDate { get; set; }
    public Dictionary<string, object>? Additional {get; set; }
}