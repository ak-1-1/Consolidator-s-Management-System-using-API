using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class StudentCollege
{
    public string Email { get; set; } = null!;

    public string? Name { get; set; }

    public DateTime? Birthdate { get; set; }

    public int? Rollno { get; set; }

    public string? Address { get; set; }

    public string? Degree { get; set; }

    public string? Department { get; set; }

    public int? Batch { get; set; }

    public decimal? Cgpa { get; set; }

    public virtual ICollection<GradeCollege> GradeColleges { get; } = new List<GradeCollege>();
}
