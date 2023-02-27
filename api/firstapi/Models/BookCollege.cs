using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class BookCollege
{
    public int BookId { get; set; }

    public string? BookName { get; set; }

    public string? Author { get; set; }

    public string? Status { get; set; }

    public string? IssuedTo { get; set; }
}
