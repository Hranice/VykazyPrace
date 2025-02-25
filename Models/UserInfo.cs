using System;
using System.Collections.Generic;

namespace VykazyPrace.Models;

public partial class UserInfo
{
    public int Id { get; set; }

    public string Jmeno { get; set; } = null!;

    public string Prijmeni { get; set; } = null!;

    public int OsCis { get; set; }

    public string WinUsername { get; set; } = null!;
    public override string ToString()
    {
        return $"{Jmeno} {Prijmeni} - {OsCis}";
    }
}
