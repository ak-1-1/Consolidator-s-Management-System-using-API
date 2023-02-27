using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class HarshitAuth
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? IsActive { get; set; }
}
