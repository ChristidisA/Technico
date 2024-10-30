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
    public static string Get(Owner owner)  // returns owner
    {
        return $"Owner Details:\n" +
               $"Name: {owner.Name}\n" +
               $"Surname: {owner.Surname}\n" +
               $"VAT Number: {owner.VATNumber}\n" +
               $"Email: {owner.Email}\n" +
               $"Phone Number: {owner.PhoneNumber}\n" +
               $"User Type: {owner.UserType}";
    }

    public static void DisplayUserDetails(int id) // Display user details by id
    {
        using (var context = new AppDbContext()) // Create instance inside the method
        {
            var owner = context.Owners.Find(id); // Fetch the owner from the database by ID
            if (owner != null) // Check if the owner was found
            {
                Console.WriteLine(Get(owner)); // Print the result of Get
            }
            else
            {
                Console.WriteLine("Owner not found.");
            }
        } // Automatically disposed of here
    }

    public static void PrintAllUsers() // Prints all users
    {
        using (var context = new AppDbContext()) // Create instance inside the method
        {
            var owners = context.Owners.ToList(); // Fetch all owners from the database
            Console.WriteLine("Here are all the users:");
            foreach (var owner in owners)
            {
                Console.WriteLine($"Name: {owner.Name} Surname: " +
                $"{owner.Surname} VAT Number: {owner.VATNumber} Email: {owner.Email} Phone Number: " +
                $"{owner.PhoneNumber} User Type: {owner.UserType}");
            }
        } // Automatically disposed of here
    }

}

