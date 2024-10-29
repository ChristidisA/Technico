using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Methods.Account;
using Technico.Models;

namespace Technico.Methods.Property_Item;

public class UpdateProperty
{
    public static void Update(int id) {
        using (var context = new AppDbContext()) 
        {
            Console.WriteLine("You selected to update a property.");



            // Find the property in the database
            var propertyToUpdate = context.Properties
                .FirstOrDefault(p => p.PropertyId == id);

            if (propertyToUpdate != null)
            {
                Console.WriteLine("Enter new details for the property (leave blank to keep current values):");

                // Update Address
                Console.WriteLine($"Current Address: {propertyToUpdate.Address}");
                Console.Write("New Address: ");
                string newAddress = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newAddress))
                {
                    propertyToUpdate.Address = newAddress;
                }

                // Update Year of Construction
                Console.WriteLine($"Current Year of Construction: {propertyToUpdate.YearOfConstruction}");
                Console.Write("New Year of Construction: ");
                string newYearInput = Console.ReadLine();
                if (int.TryParse(newYearInput, out int newYear))
                {
                    propertyToUpdate.YearOfConstruction = newYear;
                }

                // Update Owner VAT Number
                Console.WriteLine($"Current Owner VAT Number: {propertyToUpdate.OwnerVATNumber}");
                string newVatInput=Console.ReadLine();
                if (int.TryParse(newVatInput, out int newVat))
                {
                    newVatInput = ValidateVATNumber.New(newVatInput);
                    propertyToUpdate.OwnerVATNumber = newVat;
                }

                // Save changes to the database
                context.SaveChanges();
                Console.WriteLine("Property updated successfully.");
            }
            else
            {
                Console.WriteLine("Property not found.");
            }
        }
    }
}
