using System;
using System.Collections.Generic;

namespace VykazyPrace.Models;

public partial class User
{
    public int OsCis { get; set; }

    public int Loa { get; set; }
    public override string ToString()
    {
        return $"{Form1.dbint.GetUserInfoByOsCis(OsCis).Jmeno} {Form1.dbint.GetUserInfoByOsCis(OsCis).Prijmeni}";
    }

}
