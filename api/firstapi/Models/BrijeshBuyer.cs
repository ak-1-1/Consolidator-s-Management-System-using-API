using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class BrijeshBuyer
{
    public int BuyerId { get; set; }

    public string? BuyerName { get; set; }

    public string? BuyerPassword { get; set; }

    public double? InitBal { get; set; }

    public virtual ICollection<BrijeshTran> BrijeshTrans { get; } = new List<BrijeshTran>();
}
