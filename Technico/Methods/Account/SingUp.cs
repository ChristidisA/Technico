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
    public static void Execute()     // Creates an account
    {
        Console.WriteLine("Sign Up Menu");
        string registerinfo;


        Owner owner = new Owner();

        registerinfo = ValidateVATNumber.Execute();   // Validates if VAT number is 9 digit number and not a string or null
        owner.VATNumber = int.Parse(registerinfo);      // It also checks if the VAT numkber already exists
        Console.Write("Please type your name: ");
        owner.Name = Console.ReadLine();
        Console.Write("Please type your surname: ");
        owner.Surname = Console.ReadLine();
        Console.Write("Please type your address: ");
        owner.Address = Console.ReadLine();
        Console.WriteLine("Please enter your phone number (only digits):");
        registerinfo = ValidatePhoneNumber.Execute();   // Validates that it is an integer
        owner.PhoneNumber = long.Parse(registerinfo);
        Console.Write("Please type your email: ");
        owner.Email = Console.ReadLine();
        Console.Write("Please type your password: ");
        owner.Password = Console.ReadLine();
        owner.UserType = "User";

        Owner.AddOwner(owner);
        Console.Clear();
        Console.WriteLine("Account Registration Success");
        Console.WriteLine(AccountDetails.Get(owner));  // Returns the account details that was just created
    }
}
