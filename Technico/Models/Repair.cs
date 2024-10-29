using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technico.Models;

public enum RepairStatus
{
    Pending,
    InProgress,
    Complete
}

public class Repair
{
    public int RepairId { get; set; } // Unique id
    public DateTime Date { get; set; }
    public string repairDescription { get; set; }
    public string repairAddress { get; set; }
    public  RepairStatus status { get; set; }  = RepairStatus.Pending;  // Assings the pending status
    public float repairCost { get; set; } 
    public int ownerVat { get; set; }
}
