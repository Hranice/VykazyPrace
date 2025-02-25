using System;
using System.Collections.Generic;

namespace VykazyPrace.Models;

public partial class ProjectArchive
{
    public int Id { get; set; }

    public string Oznaceni { get; set; } = null!;

    public string Nazev { get; set; } = null!;
}
