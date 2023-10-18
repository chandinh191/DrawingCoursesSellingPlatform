using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Order
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? CourseId { get; set; }

    public int? PaymentMethodId { get; set; }

    public double? Price { get; set; }

    public int? CommissionPercentage { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual PaymentMethod? PaymentMethod { get; set; }

    public virtual User? User { get; set; }
}
