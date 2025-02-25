using System;
using System.Collections.Generic;

namespace VykazyPrace.Models;

public partial class Projekty
{
    public int Id { get; set; }

    public string OznaceniProjektu { get; set; } = null!;

    public string NazevProjektu { get; set; } = null!;
}
