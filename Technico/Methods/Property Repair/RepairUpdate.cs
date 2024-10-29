using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Methods.Account;
using Technico.Models;

namespace Technico.Methods.Property_Repair;

public class RepairUpdate
{
    public static void Update(int id) {
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

            // Set Date of the scheduled repair
            Console.Write("Enter the new date of repair (yyyy-MM-dd) or press enter to keep the current date: ");
            string dateInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(dateInput))
            {
                repairToUpdate.Date = DateTime.Parse(dateInput);
            }

            // Set Repair description
            Console.Write("Enter the new description or press enter to keep the current description: ");
            string descriptionInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(descriptionInput))
            {
                repairToUpdate.repairDescription = descriptionInput;
            }

            // Set Repair address
            Console.Write("Enter the new address or press enter to keep the current address: ");
            string addressInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(addressInput))
            {
                repairToUpdate.repairAddress = addressInput;
            }

            // Set Status of the repair
            Console.Write("Enter the new status (Pending, InProgress, Complete) or press enter to keep the current status: ");
            string statusInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(statusInput) && Enum.TryParse<RepairStatus>(statusInput, true, out var newStatus))
            {                                                     // It onlys assings a value to status if the user enters on of the above information
                repairToUpdate.status = newStatus;
            }

            // Set Repair cost
            Console.Write("Enter the new cost or press enter to keep the current cost: ");
            string costInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(costInput) && float.TryParse(costInput, out var newCost))
            {
                repairToUpdate.repairCost = newCost;
            }

            // Save changes to the database
            context.SaveChanges();
            Console.WriteLine("Repair record updated successfully.");
        }
    }

}
    
