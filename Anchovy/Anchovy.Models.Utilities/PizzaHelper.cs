using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anchovy.API.Client.Models;

namespace Anchovy.Models.Utilities
{
    public class PizzaHelper
    {
        public virtual double? CalculatePizzaCost(Pizza pizza)
        {
            double? runningTotal = 0;
            runningTotal += pizza.Crust.Cost;
            runningTotal += pizza.Sauce.Cost;
            runningTotal += pizza.Size.Cost;
            runningTotal += pizza.Toppings.Sum(topping => topping.Cost);
            return runningTotal;
        }

        public virtual IList<Pizza> GetMenuItemPizzas(IList<Pizza> pizzas)
        {
            return pizzas.Where(_ => _.MenuItem == true).ToList();
        }
    }
}
