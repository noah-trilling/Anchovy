using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anchovy.API.Client.Models;

namespace Anchovy.Models.Utilities
{
    public class MenuListingHelper
    {
        public virtual double? CalculateMenuListingCost(MenuListing menuListing)
        {
            double? runningTotal = 0;
            runningTotal += menuListing.Cost;
            runningTotal += menuListing.Size.Cost;
            return runningTotal;
        }
    }
}
