using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class Authorhritik
{
    public int Aid { get; set; }

    public string? Aname { get; set; }

    public int? Age { get; set; }

    public string? Place { get; set; }

    public string? Speciality { get; set; }

    public virtual ICollection<Bookhritik> Bookhritiks { get; } = new List<Bookhritik>();
}
