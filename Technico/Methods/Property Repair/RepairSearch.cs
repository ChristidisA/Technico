using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Methods.Property_Repair;

public class RepairSearch
{
    public static void Search(int id) {
        using (var context = new AppDbContext())
        {
            var repairToUpdate = context.Repairs.FirstOrDefault(r => r.RepairId == id);

            if (repairToUpdate == null)
            {
                Console.WriteLine("Repair record not found.");
                return; // Exit if the repair is not found
            }

            // Display current details
            Console.WriteLine($"Current details for Repair ID {repairToUpdate.RepairId}:");
            Console.WriteLine($"Date: {repairToUpdate.Date.ToShortDateString()}");
            Console.WriteLine($"Description: {repairToUpdate.repairDescription}");
            Console.WriteLine($"Address: {repairToUpdate.repairAddress}");
            Console.WriteLine($"Status: {repairToUpdate.status}");
            Console.WriteLine($"Cost: {repairToUpdate.repairCost:C}");
            Console.WriteLine($"Owner VAT: {repairToUpdate.ownerVat}");
        }
    }

    public static void All()
    {
        using (var context = new AppDbContext())
        {
            var repairs = context.Repairs.ToList();
            Console.WriteLine("Here are all the users: ");
            foreach (var repair in repairs)
            {
                // Display current details
                Console.Write($"Current details for Repair ID {repair.RepairId} ");
                Console.Write($"Date: {repair.Date.ToShortDateString()} ");
                Console.Write($"Description: {repair.repairDescription} ");
                Console.Write($"Address: {repair.repairAddress} ");
                Console.Write($"Status: {repair.status} ");
                Console.Write($"Cost: {repair.repairCost} ");
                Console.WriteLine($"Owner VAT: {repair.ownerVat} ");
            }
            if (repairs.Count == 0)
            {
                Console.WriteLine("No repair records registered in the system.");
            }
        }
    }
}
