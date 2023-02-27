using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class GradeCollege
{
    public string Email { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string? Grade { get; set; }

    public virtual StudentCollege EmailNavigation { get; set; } = null!;
}
