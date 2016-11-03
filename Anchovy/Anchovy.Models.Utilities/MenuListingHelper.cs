using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anchovy.API.Service.Models;

namespace Anchovy.Models.Utilities
{
    public class MenuListingHelper
    {
        public virtual decimal CalculateMenuListingCost(MenuListing menuListing)
        {
            decimal runningTotal = 0;
            runningTotal += menuListing.Cost;
            runningTotal += menuListing.Size.Cost;
            return runningTotal;
        }
    }
}
