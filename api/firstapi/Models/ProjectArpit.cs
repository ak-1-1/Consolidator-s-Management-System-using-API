using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class ProjectArpit
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? Dob { get; set; }

    public string? Branch { get; set; }

    public int? Yr { get; set; }

    public string? Pwd { get; set; }
}
