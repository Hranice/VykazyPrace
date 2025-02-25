using System;
using System.Collections.Generic;

namespace VykazyPrace.Models;

public partial class Log
{
    public int Id { get; set; }

    public string Action { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string ActionId { get; set; } = null!;

    public string Date { get; set; } = null!;
}
