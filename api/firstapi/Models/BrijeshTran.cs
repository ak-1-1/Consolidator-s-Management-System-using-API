using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class BrijeshTran
{
    public int TransId { get; set; }

    public int? BuyertId { get; set; }

    public int? PropId { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public virtual BrijeshBuyer? Buyert { get; set; }

    public virtual BrijeshProperty? Prop { get; set; }
}
