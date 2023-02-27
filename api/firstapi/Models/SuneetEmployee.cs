using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class SuneetEmployee
{
    public int EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Email { get; set; }

    public string? City { get; set; }

    public int? DeptId { get; set; }

    public virtual SuneetDept? Dept { get; set; }
}
