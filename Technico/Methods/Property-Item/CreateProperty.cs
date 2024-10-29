using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Methods.Account;
using Technico.Methods.Property_Item;
using Technico.Models;

namespace Technico.Methods.PropertyItem;

public static class CreateProperty
{

    public static void Create()
    {  // Creates a Property with all the details it needs
        using (var context = new AppDbContext())
        {
            string input;

            Console.WriteLine("Property creation menu");

            Property property = new Property();                        

            Console.WriteLine("What is the address of the property?");
            property.Address = Console.ReadLine();
            Console.WriteLine("What is the year of construction of the property?");
            input = ValidateInt.Year();                       //  Validates that the input will be 4 
            property.YearOfConstruction = int.Parse(input);
            input = ValidateVATNumber.Rules();
            property.OwnerVATNumber = int.Parse(input);
            context.Add(property);
            context.SaveChanges();
            Console.Clear();
            Console.WriteLine("Property submission success");
            PropertyDetails.View(property.PropertyId);

        }
    }
}
