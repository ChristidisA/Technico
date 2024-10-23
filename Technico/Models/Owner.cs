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
    public int Id { get; set; } // Primary Key 
    public int VATNumber { get; set; } // 9 Digits Only
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public long PhoneNumber { get; set; }
    public string Email { get; set; } // Used as Username
    public string Password { get; set; }
    public string UserType { get; set; } // e.g., homeowner, service provider,

    public static List<Owner> RegisteredOwners = new List<Owner>();

    public static void AddOwner(Owner owner)
    {
        RegisteredOwners.Add(owner);
    }

    static Owner() {
        
        Owner admin = new Owner()
        {
            Id=0,
            VATNumber = 123456789,
            Name = "Antonis",
            Surname = "Christidis",
            Address = "M. Karaoli",
            PhoneNumber = 6978943936,
            Email = "admin",
            Password = "admin",
            UserType = "Admin"
        };

        AddOwner(admin);

        Owner homeOwner = new Owner()
        {
            Id = 1,
            VATNumber = 111222333,
            Name = "Giorgos",
            Surname = "Giorgakis",
            Address = "Papandreou",
            PhoneNumber = 6987654321,
            Email = "gior",
            Password = "gos",
            UserType = "Home Owner"
        };

        AddOwner(homeOwner);

        Owner serviceProvider = new Owner()
        {
            Id = 2,
            VATNumber = 999999333,
            Name = "Pavlos",
            Surname = "Papadopoulos",
            Address = "Sugkrou",
            PhoneNumber = 6911224466,
            Email = "pav",
            Password = "los",
            UserType = "Service Provider "
        };

        AddOwner(serviceProvider);

    }
}


