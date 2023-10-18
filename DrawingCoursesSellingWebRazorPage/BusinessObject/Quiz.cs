using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Quiz
{
    public int Id { get; set; }

    public string? Quizname { get; set; }

    public int? CourseId { get; set; }

    public virtual Course? Course { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<QuizHistory> QuizHistories { get; set; } = new List<QuizHistory>();
}
