using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class Customer
{
    public int Userid { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Review> Reviews { get; } = new List<Review>();

    public virtual ICollection<TransactionVrm> TransactionVrms { get; } = new List<TransactionVrm>();
}
