using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class ManasPort
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Image { get; set; }

    public virtual ICollection<ManasFerry> ManasFerryDestinations { get; } = new List<ManasFerry>();

    public virtual ICollection<ManasFerry> ManasFerryOrigins { get; } = new List<ManasFerry>();
}
