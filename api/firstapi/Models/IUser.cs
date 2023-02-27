using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class IUser
{
    public int UserId { get; set; }

    public string UserPassword { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public string? UserPhone { get; set; }

    public virtual ICollection<IBooking> IBookings { get; } = new List<IBooking>();
}
