﻿using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Role
{
    public int Id { get; set; }

    public string? Rolename { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
