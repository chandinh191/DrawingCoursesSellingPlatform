using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Answer
{
    public int Id { get; set; }

    public int? QuestionId { get; set; }

    public string? Answer1 { get; set; }

    public bool? IsCorrect { get; set; }

    public virtual Question? Question { get; set; }
}
