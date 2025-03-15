// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com
namespace EdNexusData.Broker.Common.Requests;

public class ManifestContent
{
    public Guid? Id { get; set; }
    public string ContentType { get; set; } = default!;
    public string FileName { get; set; } = default!;
}