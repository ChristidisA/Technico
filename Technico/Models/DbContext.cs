using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Technico.Methods.Account;

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
        // Composite key for OwnerProperty
        modelBuilder.Entity<OwnerProperty>()
         .HasKey(op => new { op.OwnerId, op.PropertyId });

        modelBuilder.Entity<OwnerProperty>()
            .HasOne(op => op.Owner)
            .WithMany(o => o.OwnerProperties)
            .HasForeignKey(op => op.OwnerId)
            .OnDelete(DeleteBehavior.Restrict); // Change to Restrict to avoid cascading conflicts

        modelBuilder.Entity<OwnerProperty>()
            .HasOne(op => op.Property)
            .WithMany(p => p.OwnerProperties)
            .HasForeignKey(op => op.PropertyId)
            .OnDelete(DeleteBehavior.Cascade); // Keep this as Cascade if you want to remove Properties


        modelBuilder.Entity<Repair>()
            .HasOne(r => r.Owner)
            .WithMany(o => o.Repairs)
            .HasForeignKey(r => r.ownerVat)
            .OnDelete(DeleteBehavior.Cascade);
    }

    public class OwnerProperty
    {
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

        public int PropertyId { get; set; }
        public Property Property { get; set; }

    }


}
// connects to the database and creates owners and properties tables
