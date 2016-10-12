using System.Collections.Generic;

namespace Anchovy.API.Service.Models
{
    public class Cook : Employee
    {
        public decimal HourlyWage { get; set; }
        public decimal PieceworkRate { get; set; }
        public List<Order> Orders { get; set; }
        public List<Shift> Shifts { get; set; }
    }
}