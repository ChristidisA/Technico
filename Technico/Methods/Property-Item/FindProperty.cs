using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Methods.PropertyItem;

public  class FindProperty
{
    public static Property ById(int id) {   // Finds the property based on the id that you give it
        return Property.RegisteredProperties.FirstOrDefault(o => o.PropertyId == id);
    }


}
