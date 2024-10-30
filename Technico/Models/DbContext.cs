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
        public DbSet<Repair> Repairs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=Technico; Integrated Security=true; TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Owner>()
            .Property(o => o.VATNumber)
            .ValueGeneratedNever(); // Ensures VATNumber is not treated as an identity column

        // Relationships
        modelBuilder.Entity<Property>()
            .HasOne(p => p.Owner)
            .WithMany(o => o.Properties)
            .HasForeignKey(p => p.OwnerVATNumber)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Repair>()
            .HasOne(r => r.Owner)
            .WithMany(o => o.Repairs)
            .HasForeignKey(r => r.ownerVat)
            .OnDelete(DeleteBehavior.Cascade);
    }

}
 // connects to the database and creates owners and properties tables
