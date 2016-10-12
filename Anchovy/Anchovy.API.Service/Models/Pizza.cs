using System.Collections.Generic;

namespace Anchovy.API.Service.Models
{
    public class Pizza
    {
        public int ID { get; set; }
        public Size Size { get; set; }
        public Crust Crust { get; set; }
        public Sauce Sauce { get; set; }
        public List<Topping> Toppings { get; set; }
    }
}