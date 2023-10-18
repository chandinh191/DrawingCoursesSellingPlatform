using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Skill
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Skillname { get; set; }

    public string? Description { get; set; }

    public virtual User? User { get; set; }
}
