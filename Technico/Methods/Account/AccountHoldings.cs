using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Methods.Account;

public class AccountHoldings
{
    public static void Show() {
        using (var context = new AppDbContext()) {
            int vat= int.Parse(ValidateVATNumber.Rules()); // Validates that vat will be a 9 digit
            var properties = context.Properties
                .Where(p => p.OwnerVATNumber == vat)  // searches in the database the vat number and pulls the right columns
                .ToList();
            if (properties.Any())
            {
                Console.WriteLine($"Properties assinged with the VAT Number {vat}:");

                foreach (var property in properties)
                {
                    Console.WriteLine($"Address: {property.Address}, Year of Construction: {property.YearOfConstruction}");
                }
            }
            else {
                Console.WriteLine($"No properties were found with the assinged VAT number {vat}");
            }

        }
       
    }
}
