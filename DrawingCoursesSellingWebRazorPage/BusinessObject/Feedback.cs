using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Feedback
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public string? Evaluate { get; set; }

    public int? Point { get; set; }

    public virtual Order? Order { get; set; }
}
