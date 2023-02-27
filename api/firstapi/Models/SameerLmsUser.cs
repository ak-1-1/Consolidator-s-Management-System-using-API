using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class SameerLmsUser
{
    public string UserId { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string UserContact { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public virtual ICollection<SameerLmsBooking> SameerLmsBookings { get; } = new List<SameerLmsBooking>();
}
