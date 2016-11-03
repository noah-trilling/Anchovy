using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anchovy.API.Service.Models;

namespace Anchovy.Models.Utilities
{
    public class PizzaHelper
    {
        public virtual decimal CalculatePizzaCost(Pizza pizza)
        {
            decimal runningTotal = 0;
            runningTotal += pizza.Crust.Cost;
            runningTotal += pizza.Sauce.Cost;
            runningTotal += pizza.Size.Cost;
            runningTotal += pizza.Toppings.Sum(topping => topping.Cost);
            return runningTotal;
        }
    }
}
