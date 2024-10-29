using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Methods.Account;

public class DeleteAccount
{
    public static void Delete() {
        using (var context = new AppDbContext()) 
        {
            Console.WriteLine("You selected to delete an account.");

            // Get the account’s VAT number to identify the account
            int vat = int.Parse(ValidateVATNumber.Rules());

            // Find the owner in the database by VAT number
            var accountToDelete = context.Owners
                .FirstOrDefault(o => o.VATNumber == vat);
            var propertiesToDelete = context.Properties
                .Where(p => p.OwnerVATNumber == vat)  // searches in the database the vat number and pulls the right columns
                .ToList();
            if (accountToDelete != null)
            {
                context.Owners.Remove(accountToDelete);
                if (propertiesToDelete.Any())   // if the account has any property
                {
                    foreach (var property in propertiesToDelete)  // delete every property
                    {
                        context.Properties.Remove(property);
                    }
                }
                else
                {
                    Console.WriteLine($"No properties were found with the assinged VAT number {vat}");
                }               

                // Save changes to the database
                context.SaveChanges();
                Console.WriteLine("Account deleted successfully along with all it's properties.");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }
    }
}
