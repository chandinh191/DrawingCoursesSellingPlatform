using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class QuizHistory
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? QuizId { get; set; }

    public double? Point { get; set; }

    public virtual Quiz? Quiz { get; set; }

    public virtual User? User { get; set; }
}
