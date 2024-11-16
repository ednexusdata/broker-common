// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace EdNexusData.Broker.Domain;

public abstract class BaseEntity : SharedKernel.BaseEntity
{

    public Guid? CreatedBy { get; set; }
    public Guid? UpdatedBy { get; set; }

    [NotMapped]
    public User? CreatedByUser { get; set; }

    [NotMapped]
    public User? UpdatedByUser { get; set; }
}
