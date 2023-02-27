using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class Artistishan
{
    public int Aid { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Birthplace { get; set; }

    public string? StyleOfWork { get; set; }

    public virtual ICollection<Painting> Paintings { get; } = new List<Painting>();
}
