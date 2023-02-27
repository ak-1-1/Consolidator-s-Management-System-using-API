using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class UserList
{
    public string UserId { get; set; } = null!;

    public string? Password { get; set; }
}
