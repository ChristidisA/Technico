using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technico.Models;

public class FakeData
{ 
    private readonly AppDbContext _context;
    
    public FakeData(AppDbContext context) 
    {
        _context = context;
        _context.Database.EnsureCreated();
        SeedOwners();
        SeedProperties();
    }


    public void SeedOwners()
    {   // Creates some random users in the data base


        if (!_context.Owners.Any())
        {
            Owner admin = new Owner
            {
                VATNumber = 123456789,
                Name = "Antonis",
                Surname = "Christidis",
                Address = "M. Karaoli",
                PhoneNumber = 6978943936,
                Email = "admin",
                Password = "admin",
                UserType = "Admin"
            };

            _context.Owners.Add(admin);

            Owner homeOwner = new Owner
            {
                VATNumber = 111222333,
                Name = "Giorgos",
                Surname = "Giorgakis",
                Address = "Papandreou",
                PhoneNumber = 6987654321,
                Email = "gior",
                Password = "gos",
                UserType = "Home Owner"
            };

            _context.Owners.Add(homeOwner);

            Owner serviceProvider = new Owner
            {
                VATNumber = 999999333,
                Name = "Pavlos",
                Surname = "Papadopoulos",
                Address = "Sugkrou",
                PhoneNumber = 6911224466,
                Email = "pav",
                Password = "los",
                UserType = "Service Provider"
            };

            _context.Owners.Add(serviceProvider);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }

    public void SeedProperties()
    {                              // Creates random properties inside the database
        if (!_context.Properties.Any())
        {
            Property property1 = new Property()
            {
                Address = "Papandreou 10",
                YearOfConstruction = 2005,
                OwnerVATNumber = 123456789
            };
            _context.Properties.Add(property1);

            Property property2 = new Property()
            {
                Address = "Ionos Dragoumi",
                YearOfConstruction = 1999,
                OwnerVATNumber = 111222333
            };
            _context.Properties.Add(property2);

            Property property3 = new Property()
            {
                Address = "25 Martiou",
                YearOfConstruction = 1997,
                OwnerVATNumber = 111222333
            };
            _context.Properties.Add(property3);

            Property property4 = new Property()
            {
                Address = "28 Oktobriou",
                YearOfConstruction = 1995,
                OwnerVATNumber = 111222333
            };
            _context.Properties.Add(property4);

            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}

