using System;
using Anchovy.API.Client.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anchovy.API.Client.Tests
{
    [TestClass]
    public class OrdersTests : AnchovyApiClientTests
    {
        private IOrders _orders;
        private ILines _lines;

        [TestMethod]
        public void TestObjectLifecycle()
        {
            _orders = Service.Orders;
            _lines = Service.Lines;
            PostTest();
            PutTest();
            DeleteTest();
        }

        private void DeleteTest()
        {
            if (Order.Id == null) return;
            var deletedOrder = _orders.DeleteOrder(Order.Id.Value);
            TestOrder(Order, deletedOrder);
        }

        private void GetTest(Order order)
        {
            if (order.Id == null) return;
            var gotOrder = _orders.GetOrder(order.Id.Value);
            TestOrder(order, gotOrder);
        }

        private void PutTest()
        {
            if (Order.Id == null) return;
            Order.CancelledTimeStamp = DateTimeOffset.UtcNow;
            _orders.PutOrder(Order.Id.Value, Order);
            GetTest(Order);
        }

        private void PostTest()
        {
            var postedOrder = _orders.PostOrder(Order);
            Order = postedOrder;
            GetTest(Order);
        }

        public void TestOrder(Order expected, Order actual)
        {
            if (expected.Id == null || actual.Id == null) return;
            Assert.AreEqual(expected.Id.Value, actual.Id.Value);
            Assert.AreEqual(expected.CancelledTimeStamp, actual.CancelledTimeStamp);
        }
    }
}

