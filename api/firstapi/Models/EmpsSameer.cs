using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class EmpsSameer
{
    public int Eid { get; set; }

    public string Ename { get; set; } = null!;

    public string Ecity { get; set; } = null!;

    public int Esal { get; set; }

    public DateTime Edoj { get; set; }
}
