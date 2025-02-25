using System;
using System.Collections.Generic;

namespace VykazyPrace.Models;

public partial class Record
{
    public int Id { get; set; }

    public string Date { get; set; } = null!;

    public string ProjectId { get; set; } = null!;

    public string? Activity { get; set; }

    public string Hours { get; set; } = null!;

    public int OsCis { get; set; }

    public int Archive { get; set; }

    public int Zakazka { get; set; }
}
