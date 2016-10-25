using System;
using Anchovy.API.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anchovy.API.Client.Tests
{
    [TestClass]
    public class AnchovyApiServiceTests : AnchovyApiClientTests
    {
        [TestMethod]
        public void InitializeAnchovyApiService()
        {
            Assert.IsNotNull(Service);
            Assert.IsNotNull(Service.BaseUri);
            Assert.AreEqual(Service.BaseUri.ToString(), "http://localhost:59971/");
            Assert.IsNotNull(Service.Cooks);
            Assert.IsNotNull(Service.Crusts);
            Assert.IsNotNull(Service.Customers);
            Assert.IsNotNull(Service.Lines);
            Assert.IsNotNull(Service.Managers);
            Assert.IsNotNull(Service.MenuListings);
            Assert.IsNotNull(Service.Orders);
            Assert.IsNotNull(Service.Pizzas);
            Assert.IsNotNull(Service.Sauces);
            Assert.IsNotNull(Service.Shifts);
            Assert.IsNotNull(Service.Sizes);
            Assert.IsNotNull(Service.Toppings);
        }
    }
}
