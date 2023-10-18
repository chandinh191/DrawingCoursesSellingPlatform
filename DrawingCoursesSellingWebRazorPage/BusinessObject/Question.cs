using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Question
{
    public int Id { get; set; }

    public string? Detail { get; set; }

    public int? QuizId { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public virtual Quiz? Quiz { get; set; }
}
