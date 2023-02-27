using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class HarshitEmpAbout
{
    public int AId { get; set; }

    public string EName { get; set; } = null!;

    public string EDept { get; set; } = null!;

    public string ESdept { get; set; } = null!;

    public string EQual { get; set; } = null!;

    public string EHobbies { get; set; } = null!;

    public int EmpId { get; set; }
}
