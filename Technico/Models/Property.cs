using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technico.Models;

public class Property
{
    public int PropertyId { get; set; } // Unique id
    public string Address { get; set; }
    public int YearOfConstruction { get; set; }
    public int OwnerVATNumber { get; set; }

    public static List<Property> RegisteredProperties = new List<Property>();  // Creates a list


    public static void AddProperty(Property property) {  // Adds object property inside the list RegisteredProperties
        RegisteredProperties.Add(property);
    }
    
    static Property() {                                    // Creates random properties

        Property property1 = new Property() {
            PropertyId = 0,
            Address = "Papandreou 10",
            YearOfConstruction = 2005,
            OwnerVATNumber = 123456789
        };
        AddProperty(property1);

        Property property2 = new Property()
        {
            PropertyId = 1,
            Address = "Ionos Dragoumi",
            YearOfConstruction = 1999,
            OwnerVATNumber = 111222333
        };
        AddProperty(property2);
    }

    

}
