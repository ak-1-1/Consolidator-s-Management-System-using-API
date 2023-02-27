using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class BrijeshProperty
{
    public int PropertyId { get; set; }

    public int? SellerpId { get; set; }

    public string? PName { get; set; }

    public string? Loc { get; set; }

    public double? RentPd { get; set; }

    public virtual ICollection<BrijeshTran> BrijeshTrans { get; } = new List<BrijeshTran>();

    public virtual BrijeshSeller? Sellerp { get; set; }
}
