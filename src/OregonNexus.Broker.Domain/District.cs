namespace OregonNexus.Broker.Domain;

public class District
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Number { get; set; }

    public Address? Address { get; set; }

    public string? Domain { get; set; }

    public ICollection<School>? Schools { get; set; }
}