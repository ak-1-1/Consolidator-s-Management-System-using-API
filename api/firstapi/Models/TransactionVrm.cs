using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class TransactionVrm
{
    public int TransactionId { get; set; }

    public int VehicleId { get; set; }

    public int Userid { get; set; }

    public DateTime RentalStartDate { get; set; }

    public decimal RentalRate { get; set; }

    public DateTime? RentalEndDate { get; set; }

    public virtual Customer User { get; set; } = null!;

    public virtual Vehicle Vehicle { get; set; } = null!;
}
