using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class RahulBook
{
    public int BookId { get; set; }

    public string BookName { get; set; } = null!;

    public string BookAuthor { get; set; } = null!;

    public int BookQty { get; set; }

    public virtual ICollection<RahulBooking> RahulBookings { get; } = new List<RahulBooking>();
}
