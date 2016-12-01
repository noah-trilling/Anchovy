
using System.Collections.Generic;
using System.Linq;
using Anchovy.API.Client.Models;
using Anchovy.API.Service.Models;
using Cook = Anchovy.API.Client.Models.Cook;
using Customer = Anchovy.API.Client.Models.Customer;
using Order = Anchovy.API.Client.Models.Order;

namespace Anchovy.Models.Utilities
{
    public class OrderHelper
    {
        public virtual double? CalculateOrderCost(Order order)
        {
            var lineHelper = new LineHelper();
            return 0.0;//order.Lines.Sum(line => lineHelper.CalculateLineCost(line));
        }

        public virtual IList<Order> GetOrdersByStatus(IList<Order> orders, OrderStatus orderStatus)
        {
            return orders.Where(_ => _.OrderStatus.Equals(orderStatus)).ToList();
        }

        public virtual IList<Order> GetCookOrders(IList<Order> orders, Cook cook)
        {
            return orders.Where(_ => _.CookId.Equals(cook.Id)).ToList();
        }

        public virtual IList<Order> GetCookOrdersByStatus(IList<Order> orders, Cook cook, OrderStatus orderStatus)
        {
            return orders.Where(_ => _.CookId.Equals(cook.Id) && _.OrderStatus.Equals(orderStatus)).ToList();
          //  GetCookOrdersByStatus(orders, cook, )
        }

        public virtual IList<Order> GetCustomerOrders(IList<Order> orders, Customer customer)
        {
            return orders.Where(_ => _.CustomerId.Equals(customer.Id)).ToList();
        }
        public virtual IList<Order> GetCustomerOrdersByStatus(IList<Order> orders, Customer customer, OrderStatus orderStatus)
        {
            return orders.Where(_ => _.CustomerId.Equals(customer.Id) && _.OrderStatus.Equals(orderStatus)).ToList();
        }
    }
}
