using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class PaymentMethod
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
