using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class Vehicle
{
    public int VehicleId { get; set; }

    public string ModelName { get; set; } = null!;

    public string RegistrationNumber { get; set; } = null!;

    public string VehicleType { get; set; } = null!;

    public int DailyRent { get; set; }

    public bool? IsAvailable { get; set; }

    public virtual ICollection<Review> Reviews { get; } = new List<Review>();

    public virtual ICollection<TransactionVrm> TransactionVrms { get; } = new List<TransactionVrm>();
}
