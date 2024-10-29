using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Technico.Models;

    public class AppDbContext : DbContext
    {        

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Property> Properties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=Technico; Integrated Security=true; TrustServerCertificate=True;");
    }

}
 // connects to the database and creates owners and properties tables
