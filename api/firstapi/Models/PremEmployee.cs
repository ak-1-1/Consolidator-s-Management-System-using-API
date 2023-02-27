using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class PremEmployee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Department { get; set; }

    public DateTime? Doj { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public int? ManagerId { get; set; }

    public virtual ICollection<PremEmployee> InverseManager { get; } = new List<PremEmployee>();

    public virtual PremEmployee? Manager { get; set; }

    public virtual ICollection<PremAttendance> PremAttendanceEmps { get; } = new List<PremAttendance>();

    public virtual ICollection<PremAttendance> PremAttendanceManagers { get; } = new List<PremAttendance>();
}
