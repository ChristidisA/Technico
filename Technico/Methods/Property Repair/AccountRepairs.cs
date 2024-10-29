using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Methods.Account;
using Technico.Models;

namespace Technico.Methods.Property_Repair
{
    public class AccountRepairs
    {
        public static void ShowAll()
        {
            using (var context = new AppDbContext())
            {
                // Prompt the user for the VAT number
                var vatNumber = int.Parse(ValidateVATNumber.Rules());

                // Query the database for repairs associated with the provided VAT number
                var repairs = context.Repairs
                                     .Where(r => r.ownerVat == vatNumber)
                                     .ToList();

                // Check if any repairs were found
                if (repairs.Count == 0)
                {
                    Console.WriteLine("No repairs found for the provided VAT number.");
                    return;
                }

                // Display the repairs
                Console.WriteLine($"Repairs associated with VAT number {vatNumber}:");
                foreach (var repair in repairs)
                {
                    Console.WriteLine($"- Repair ID: {repair.RepairId}, Date: {repair.Date.ToShortDateString()}, " +
                                      $"Description: {repair.repairDescription}, Address: {repair.repairAddress}, " +
                                      $"Status: {repair.status}, Cost: {repair.repairCost}€");
                }

            }
        }
    }
}
