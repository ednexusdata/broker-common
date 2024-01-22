namespace OregonNexus.Broker.Domain;

public class School
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Number { get; set; }

    public Address? Address { get; set; }
}