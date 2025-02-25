using System;
using System.Collections.Generic;

namespace VykazyPrace.Models;

public partial class ZakazkyArchive
{
    public int Id { get; set; }

    public int CisloZakazky { get; set; }

    public string? TypZakazky { get; set; }

    public string Nazev { get; set; } = null!;

    public string? Autor { get; set; }

    public string? Poznamky { get; set; }
}
