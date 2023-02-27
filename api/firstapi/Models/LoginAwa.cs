using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class LoginAwa
{
    public string Userid { get; set; } = null!;

    public string? Pword { get; set; }

    public string? Username { get; set; }

    public string? Phonenumber { get; set; }
}
