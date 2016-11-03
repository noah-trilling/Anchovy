using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anchovy.API.Service.Models;

namespace Anchovy.Models.Utilities
{
    public class LineHelper
    {
        public virtual decimal CalculateLineCost(Line line)
        {
            var listingHelper = new MenuListingHelper();
            var pizzaHelper = new PizzaHelper();
            if (line.MenuListing != null)
                return listingHelper.CalculateMenuListingCost(line.MenuListing) * line.Quantity;
            return pizzaHelper.CalculatePizzaCost(line.Pizza) * line.Quantity;
        }
    }
}
