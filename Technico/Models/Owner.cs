using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Technico.Methods.Account;
using static Technico.Models.AppDbContext;

namespace Technico.Models;

public class Owner
{
    [Key]
    [Required]
    [StringLength(9, ErrorMessage = "VATNumber must be 9 digits long.")]
    public int VATNumber { get; set; }

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public long PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string UserType { get; set; }

    public ICollection<OwnerProperty> OwnerProperties { get; set; }
    public ICollection<Repair> Repairs { get; set; }
}

