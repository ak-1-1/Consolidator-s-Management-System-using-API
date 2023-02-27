using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class ManasUser
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Name { get; set; }

    public string? Email { get; set; }

    public double Wallet { get; set; }

    public virtual ICollection<ManasTicket> ManasTickets { get; } = new List<ManasTicket>();
}
