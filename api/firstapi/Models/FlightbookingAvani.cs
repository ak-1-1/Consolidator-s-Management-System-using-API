using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class FlightbookingAvani
{
    public int Bid { get; set; }

    public int? FlightNo { get; set; }

    public int? Seats { get; set; }

    public int? TotalPrice { get; set; }

    public virtual FlightAvani? FlightNoNavigation { get; set; }
}
