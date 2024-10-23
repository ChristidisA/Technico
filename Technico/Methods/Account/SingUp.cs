using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Methods;
using Technico.Models;

namespace Technico.Methods.Account;

public class SingUp
{
    public static void Execute()
    {
        Console.Clear();
        Console.WriteLine("Sign Up Menu");
        string registerinfo;


        Owner owner = new Owner();

        registerinfo = ValidateVATNumber.Execute();
        owner.VATNumber = int.Parse(registerinfo);
        Console.Write("Please type your name: ");
        owner.Name = Console.ReadLine();
        Console.Write("Please type your surname: ");
        owner.Surname = Console.ReadLine();
        Console.Write("Please type your address: ");
        owner.Address = Console.ReadLine();
        Console.WriteLine("Please enter your phone number (only digits):");
        registerinfo = ValidatePhoneNumber.Execute();
        owner.PhoneNumber = long.Parse(registerinfo);
        Console.Write("Please type your email: ");
        owner.Email = Console.ReadLine();
        Console.Write("Please type your password: ");
        owner.Password = Console.ReadLine();
        owner.UserType = "User";

        Owner.AddOwner(owner);
        Console.Clear();
        Console.WriteLine("Account Registration Success");
        Console.WriteLine(AccountDetails.Get(owner));
    }
}
