using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Methods.Account;
using Technico.Models;

namespace Technico.Methods.Property_Repair;

public class RepairCreation
{
    public static void Create()
    {
        using (var context = new AppDbContext())
        {
            Repair repair = new Repair();

            Console.WriteLine("Creating a new repair record.");

            // Set Date of the scheduled repair
            Console.Write("Enter the date of repair (yyyy-MM-dd): ");
            DateTime date;
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.Write("Invalid input. Please enter a valid format date (yyyy-mm-dd) for the repair: ");
            }

            // Set Repair description
            Console.Write("Enter the type of repair (e.g., Painting, Insulation, Frames, Plumbing, Electrical work): ");
            repair.repairDescription = Console.ReadLine();

            // Set Repair cost
            float cost;
            Console.Write("Enter the estimated cost of the repair: ");
            while (!float.TryParse(Console.ReadLine(), out cost))
            {
                Console.Write("Invalid input. Please enter a valid number for the repair cost: ");
            }
            repair.repairCost = cost;

            // Set Repair address
            Console.Write("Enter the address for the repair: ");
            repair.repairAddress = Console.ReadLine();

            // Set Status of the repair, defaulting to "Pending"
            repair.status = RepairStatus.Pending;

            // Set Owner VAT number for whom the repair is made
            Console.Write("Enter the VAT number of the owner: ");
            repair.ownerVat = int.Parse(ValidateVATNumber.Rules());

            // Check if the VAT and address match with the properties in the database
            var propertyExists = context.Properties.Any(p => p.OwnerVATNumber == repair.ownerVat && p.Address == repair.repairAddress);

            if (!propertyExists)
            {
                Console.WriteLine("No matching property found with the given VAT number and address.");
                return; // Exit the method if no matching property is found
            }

            // Add the new repair to the database
            context.Repairs.Add(repair);

            // Save changes to the database
            context.SaveChanges();
            Console.WriteLine("Repair record created successfully.");
        }
    }
}
