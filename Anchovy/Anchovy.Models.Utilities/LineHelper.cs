using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anchovy.API.Client.Models;

namespace Anchovy.Models.Utilities
{
    public class LineHelper
    {
        public virtual double? CalculateLineCost(Line line)
        {
            var listingHelper = new MenuListingHelper();
            var pizzaHelper = new PizzaHelper();
            if (line.MenuListing != null)
                return listingHelper.CalculateMenuListingCost(line.MenuListing) * line.Quantity;
            return pizzaHelper.CalculatePizzaCost(line.Pizza) * line.Quantity;
        }
    }
}
