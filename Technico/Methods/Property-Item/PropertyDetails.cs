using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Methods.PropertyItem;

public class PropertyDetails
{
    public static string Get(Property property)   // returns object property
    { 
        return $"Property Details:\n" +
               $"Id {property.PropertyId}:\n" +
               $"Address: {property.Address}\n" +
               $"Year of construction: {property.YearOfConstruction}\n" +
               $"Owners VAT number : {property.OwnerVATNumber}";
    }

    public static void View(int id) {               //  Checks if there is a property based on the id
        Property property = FindProperty.ById(id);
        if (property != null)
        {
            Console.WriteLine(Get(property));
        }
        else {
            Console.WriteLine("Property not found.");
        }
    }




}
