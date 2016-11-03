using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anchovy.API.Service.Models;

namespace Anchovy.Models.Utilities
{
    public class OrderHelper
    {
        public virtual decimal CalculateOrderCost(Order order)
        {
            var lineHelper = new LineHelper();
            return order.Lines.Sum(line => lineHelper.CalculateLineCost(line));
        }
    }
}
