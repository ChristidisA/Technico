using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Technico.Methods.Account;

namespace Technico.Models;

public class Owner
{
    public int Id { get; set; }// Primary Key - Auto-incremented
    public int VATNumber { get; set; } // 9 Digits Only
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public long PhoneNumber { get; set; }
    public string Email { get; set; } // Used as Username
    public string Password { get; set; }
    public string UserType { get; set; } // e.g., homeowner, service provider,

}


