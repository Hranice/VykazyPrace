using System;
using System.Collections.Generic;

namespace VykazyPrace.Models;

public partial class UserInfo
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public int PersonalNumber { get; set; }

    public string WindowsUsername { get; set; } = null!;

    public int? LevelOfAccess { get; set; }
}
