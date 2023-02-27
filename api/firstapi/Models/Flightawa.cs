using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class Flightawa
{
    public int Uid { get; set; }

    public string Uname { get; set; } = null!;

    public string Jfrom { get; set; } = null!;

    public string Jto { get; set; } = null!;

    public int Nticket { get; set; }

    public DateTime Doj { get; set; }

    public string? Cid { get; set; }

    public virtual Companyawa? CidNavigation { get; set; }
}
