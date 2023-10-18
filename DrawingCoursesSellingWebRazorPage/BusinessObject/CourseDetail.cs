using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class CourseDetail
{
    public int Id { get; set; }

    public int? CourseId { get; set; }

    public string? Document { get; set; }

    public string? SourceVideopath { get; set; }

    public virtual Course? Course { get; set; }
}
