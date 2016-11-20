using System.Collections.Generic;

namespace Anchovy.API.Service.Models
{
    public class Topping
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public int LowLevel { get; set; }
    }
}