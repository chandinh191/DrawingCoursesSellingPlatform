using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class User
{
    public int Id { get; set; }

    public int? RoleId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public double? Wallet { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<QuizHistory> QuizHistories { get; set; } = new List<QuizHistory>();

    public virtual Role? Role { get; set; }

    public virtual ICollection<Skill> Skills { get; set; } = new List<Skill>();
}
