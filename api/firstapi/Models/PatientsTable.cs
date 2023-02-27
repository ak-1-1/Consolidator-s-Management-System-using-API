using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class PatientsTable
{
    public int Pid { get; set; }

    public string? Pname { get; set; }

    public string? Problem { get; set; }

    public DateTime? Doj { get; set; }

    public string? City { get; set; }

    public string? Pstatus { get; set; }
}
