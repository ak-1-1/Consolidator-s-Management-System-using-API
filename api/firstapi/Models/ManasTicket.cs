using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class ManasTicket
{
    public int Id { get; set; }

    public int AdultCount { get; set; }

    public double Cost { get; set; }

    public int RoomNo { get; set; }

    public int UserId { get; set; }

    public int FerryId { get; set; }

    public virtual ManasFerry Ferry { get; set; } = null!;

    public virtual ManasUser User { get; set; } = null!;
}
