using Microsoft.EntityFrameworkCore;
using System;
using Technico.Models;

namespace Technico.Methods.Account
{
    public class SingUp
    {
        // Static method to handle sign-up process
        public static void Execute()
        {
            using (var context = new AppDbContext())
            {
                Console.WriteLine("Sign Up Menu");
                string registerInfo;

                Owner owner = new Owner();

                registerInfo = ValidateVATNumber.Execute(); // Validates VAT number
                owner.VATNumber = int.Parse(registerInfo);
                Console.Write("Please type your name: ");
                owner.Name = Console.ReadLine();
                Console.Write("Please type your surname: ");
                owner.Surname = Console.ReadLine();
                Console.Write("Please type your address: ");
                owner.Address = Console.ReadLine();
                Console.WriteLine("Please enter your phone number (only digits):");
                registerInfo = ValidatePhoneNumber.Execute(); // Validates phone number
                owner.PhoneNumber = long.Parse(registerInfo);
                Console.Write("Please type your email: ");
                owner.Email = Console.ReadLine();
                Console.Write("Please type your password: ");
                owner.Password = Console.ReadLine();
                owner.UserType = "User";

                // Add owner to the database
                context.Owners.Add(owner);
                context.SaveChanges(); // Save changes to the database

                Console.Clear();
                Console.WriteLine("Account Registration Success");
                Console.WriteLine(AccountDetails.Get(owner)); // Display account details
            }
        }
    }
}
