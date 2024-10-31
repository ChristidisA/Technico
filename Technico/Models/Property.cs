using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Technico.Models.AppDbContext;

namespace Technico.Models;

public class Property
{
    public int PropertyId { get; set; } // Unique id
    public string Address { get; set; }
    public int YearOfConstruction { get; set; }
    
    // Foreign Key
    public int OwnerVATNumber { get; set; }
    public Owner Owner { get; set; } // Navigation property

    public ICollection<OwnerProperty> OwnerProperties { get; set; }
}
