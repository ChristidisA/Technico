using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Technico.Models;

namespace Technico.Methods.Account;

public class AccountDetails
{
    public static string Get(Owner owner)
    {
        return $"Owner Details:\n" +
               $"ID: {owner.Id}\n" +
               $"Name: {owner.Name}\n" +
               $"Surname: {owner.Surname}\n" +
               $"VAT Number: {owner.VATNumber}\n" +
               $"Email: {owner.Email}\n" +
               $"Phone Number: {owner.PhoneNumber}\n" +
               $"User Type: {owner.UserType}";
    }


    public static void PrintAllUsers()
    {
        foreach (var owner in Owner.RegisteredOwners)
        {
            Console.WriteLine($"Owner Details: ID: {owner.Id} Name: {owner.Name} Surname: " +
            $"{owner.Surname} VAT Number: {owner.VATNumber} Email: {owner.Email} Phone Number: " +
            $"{owner.PhoneNumber} User Type: {owner.UserType}");
        }
    }


    public static void DiplayUserDetails(int id) {
        Owner owner = FindOwner.ById(id);
        if (owner != null) // Check if the owner was found
        {
            // Print owner details
            Console.WriteLine(AccountDetails.Get(owner)); // Print the result of AccountDetails.Get
        }
        else
        {
            Console.WriteLine("Owner not found.");
        }
    }

}
