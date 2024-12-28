namespace EdNexusData.Broker.Common.Connector;

public interface IConnector
{
    public static string DisplayName { get; } = default!;
    public static string AuthorName { get; } = default!;
    public static string AbbreviatedAuthorName { get; } = default!;
}