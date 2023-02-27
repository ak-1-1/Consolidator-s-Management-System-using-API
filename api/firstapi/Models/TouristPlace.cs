using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class TouristPlace
{
    public int PlaceId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;

    public decimal PlaceRating { get; set; }

    public virtual ICollection<PlaceImage> PlaceImages { get; } = new List<PlaceImage>();

    public virtual ICollection<ServiceProvider> Providers { get; } = new List<ServiceProvider>();
}
