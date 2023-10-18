using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Course
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public double? Price { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<CourseDetail> CourseDetails { get; set; } = new List<CourseDetail>();

    public virtual ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();

    public virtual User? User { get; set; }
}
