using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Methods.Property_Repair;

public class RepairDelete
{
    public static void Delete(int id) {
        using (var context = new AppDbContext())
        {
            var repairToDelete = context.Repairs.FirstOrDefault(r => r.RepairId == id);

            if (repairToDelete == null)
            {
                Console.WriteLine("Repair record not found.");
                return; // Exit if the repair is not found
            }


            context.Repairs.Remove(repairToDelete);
            context.SaveChanges();
            Console.WriteLine("Repair record deleted successfully.");
        }
    }
}
