using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class SameerLmsBooking
{
    public string UserId { get; set; } = null!;

    public string Isbn { get; set; } = null!;

    public string Usbn { get; set; } = null!;

    public string IssueDate { get; set; } = null!;

    public string? ReturnDate { get; set; }

    public virtual SameerLmsBookCollection IsbnNavigation { get; set; } = null!;

    public virtual SameerLmsUser User { get; set; } = null!;
}
