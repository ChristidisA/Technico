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

}
