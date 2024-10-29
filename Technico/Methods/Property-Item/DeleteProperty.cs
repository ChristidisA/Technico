using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Methods.Account;
using Technico.Models;

namespace Technico.Methods.Property_Item;

public class DeleteProperty
{
    public static void Delete() {
        using (var context = new AppDbContext()) {
            Console.WriteLine("You selected to delete a property.");
            int vat= int.Parse(ValidateVATNumber.Rules());
            Console.WriteLine("Enter the property's address");
            string address= Console.ReadLine();
            var propertyToDelete = context.Properties.FirstOrDefault(p => p.OwnerVATNumber == vat && p.Address == address);
            if (propertyToDelete != null)
            {
                context.Properties.Remove(propertyToDelete);
                context.SaveChanges();
                Console.WriteLine("Property deleteed successfully");
            }
            else {
                Console.WriteLine("Property not found");
            }

        }
    }
}
