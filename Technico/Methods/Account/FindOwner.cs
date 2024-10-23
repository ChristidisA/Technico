using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Methods.Account;

public class FindOwner
{
    public static Owner ById(int id)
    {
        return Owner.RegisteredOwners.FirstOrDefault(o => o.Id == id);
    }

    public static Owner ByMailPass(string email, string password)
    {
        return Owner.RegisteredOwners.FirstOrDefault(o => o.Email == email && o.Password == password);
    }


}
