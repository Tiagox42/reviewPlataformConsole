using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewPlataformConsole.Entities.Person.Enums
{
    internal enum Role : int
    {
        Basic = 0,
        Editor = 1,
        Mod = 2,
        Admin = 3,
        Influencer = 4,
        Critic = 5,
        Company = 6,
        Banned = 7,
    }
}
