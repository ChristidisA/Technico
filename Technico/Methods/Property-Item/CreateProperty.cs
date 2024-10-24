using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Methods.Account;
using Technico.Methods.Property_Item;
using Technico.Models;

namespace Technico.Methods.PropertyItem;

public class CreateProperty
{

    public static void Create() {  // Creates a Property with all the details it needs
        string input;

        Console.WriteLine("Property creation menu");

        Property property = new Property();

        int nextId = Property.RegisteredProperties.Count > 0    // This part of the code makes sure that a unique id is assinged to the new property created
            ? Property.RegisteredProperties.Max(p => p.PropertyId) + 1
            : 1; // If no properties exist, start with ID 1 else register a valid id

        property.PropertyId = nextId;
        Console.WriteLine("What is the address of the property?");
        property.Address = Console.ReadLine();
        Console.WriteLine("What is the year of construction of the property?");
        input = ValidateInt.Year();                       //  Validates that the input will be 4 
        property.YearOfConstruction = int.Parse(input);
        input = ValidateVATNumber.Rules();
        property.OwnerVATNumber = int.Parse(input);   
        Property.AddProperty(property);
        Console.Clear();
        Console.WriteLine("Property submission success");
        PropertyDetails.View(property.PropertyId);


    }

}
