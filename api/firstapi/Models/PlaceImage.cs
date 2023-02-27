using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class PlaceImage
{
    public int ImageId { get; set; }

    public int? PlaceId { get; set; }

    public string ImageUrl { get; set; } = null!;

    public virtual TouristPlace? Place { get; set; }
}
