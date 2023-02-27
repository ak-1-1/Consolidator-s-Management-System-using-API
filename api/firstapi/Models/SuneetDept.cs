using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class SuneetDept
{
    public int DeptId { get; set; }

    public string? Dname { get; set; }

    public int? NoOfEmployees { get; set; }

    public virtual ICollection<SuneetEmployee> SuneetEmployees { get; } = new List<SuneetEmployee>();
}
