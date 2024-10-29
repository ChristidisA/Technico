using System;
using System.Linq;
using Technico.Models;

namespace Technico.Methods.Account;

public class FindOwner
{
    public static void SeedDatabase(AppDbContext context)
    {
        var fakeData = new FakeData(context); // Seed the database
    }

    public static Owner ByMailPass(string email, string password)
    {
        using (var context = new AppDbContext()) // Create a new context inside the method
        {
            // Query the Owners table in the database
            return context.Owners.FirstOrDefault(o => o.Email == email && o.Password == password);
        }
    }

    public static void AuthenticateOwner(string email, string password)
    {
        using (var context = new AppDbContext()) // Create a new context inside the method
        {
            SeedDatabase(context); // Seed the database first

            // Now you can find an owner by email and password
            var loggedInOwner = ByMailPass(email, password);
            if (loggedInOwner != null)
            {
                Console.WriteLine("Owner found!");
                // You can now use the loggedInOwner object
            }
            else
            {
                Console.WriteLine("Owner not found.");
            }
        }
    }
}
