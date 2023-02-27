using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class Review
{
    public int ReviewId { get; set; }

    public int Userid { get; set; }

    public int VehicleId { get; set; }

    public string Review1 { get; set; } = null!;

    public virtual Customer User { get; set; } = null!;

    public virtual Vehicle Vehicle { get; set; } = null!;
}
