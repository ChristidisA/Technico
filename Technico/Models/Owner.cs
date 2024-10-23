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
    public int VATNumber { get; set; } // 9 Digits Only
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public long PhoneNumber { get; set; }
    public string Email { get; set; } // Used as Username
    public string Password { get; set; }
    public string UserType { get; set; } // e.g., homeowner, service provider,

    public string GetAccountDetails()
    {
        return $"Owner Details:\n" +
               $"Name: {Name}\n" +
               $"Surname: {Surname}\n" +
               $"VAT Number: {VATNumber}\n" +
               $"Email: {Email}\n" +
               $"Phone Number: {PhoneNumber}\n" +
               $"User Type: {UserType}";
    }

    public static List<Owner> RegisteredOwners = new List<Owner>();

    public static void AddOwner(Owner owner)
    {
        RegisteredOwners.Add(owner);
    }

    public static Owner FindOwner(string email, string password)
    {
        return RegisteredOwners.FirstOrDefault(o => o.Email == email && o.Password == password);
    }

    public static void PrintAllOwners()
    {
        foreach (var owner in RegisteredOwners)
        {
            Console.WriteLine(owner.GetAccountDetails());
        }
    }

    public static bool AdminExists()
    {
        return RegisteredOwners.Any(o => o.UserType == "Admin");
    }

    static Owner() {
        if (!AdminExists())
        {

            Owner admin = new Owner()
            {
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

        }
    }
    
}


