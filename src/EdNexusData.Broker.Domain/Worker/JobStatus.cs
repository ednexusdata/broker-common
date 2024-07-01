using System.ComponentModel;

namespace EdNexusData.Broker.Domain.Worker;

public enum JobStatus
{
    [Description("Waiting")]
    Waiting,
    
    [Description("Running")]
    Running,

    [Description("Complete")]
    Complete,

    [Description("Aborted")]
    Aborted,

    [Description("Interrupted")]
    Interrupted,

    [Description("Failed")]
    Failed
}