using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class EmpHritik
{
    public int Eid { get; set; }

    public string? Ename { get; set; }

    public int? Salary { get; set; }

    public DateTime? Doj { get; set; }

    public string? City { get; set; }
}
