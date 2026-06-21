using EdNexusData.Broker.Common.Students;

namespace EdNexusData.Broker.Common.Mappings;

public class MappingStudentAttributes
{
    public StudentAttributes? IncomingStudentAttributes { get; set; }
    public StudentAttributes? OutgoingStudentAttributes { get; set; }
}