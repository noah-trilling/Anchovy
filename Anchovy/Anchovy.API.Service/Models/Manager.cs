using System.Collections.Generic;

namespace Anchovy.API.Service.Models
{
    public class Manager : Employee
    {
        public decimal Salary { get; set; }
        public List<Cook> Cooks { get; set; }
    }
}