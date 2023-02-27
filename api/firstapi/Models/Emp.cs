using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class Emp
{
    public int Eid { get; set; }

    public string? Ename { get; set; }

    public int? Salary { get; set; }

    public DateTime? Doj { get; set; }

    public string? City { get; set; }

    public string? Hobbies { get; set; }

    public string? Awards { get; set; }

    public string? TeamName { get; set; }

    public string? TeamLead { get; set; }

    public virtual Team? TeamNameNavigation { get; set; }
}
