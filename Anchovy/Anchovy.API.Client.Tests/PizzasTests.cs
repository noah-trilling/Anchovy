using System;
using Anchovy.API.Client.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anchovy.API.Client.Tests
{
    [TestClass]
    public class PizzasTests : AnchovyApiClientTests
    {
        private IPizzas _pizzas;

        [TestMethod]
        public void TestObjectLifecycle()
        {
            _pizzas = Service.Pizzas;
            PostTest();
            PutTest();
            DeleteTest();
        }

        private void DeleteTest()
        {
            if (Pizza.Id == null) return;
            var deletedPizza = _pizzas.DeletePizza(Pizza.Id.Value);
            TestOrder(Pizza, deletedPizza);
        }

        private void GetTest(Pizza pizza)
        {
            if (pizza.Id == null) return;
            var gotPizza = _pizzas.GetPizza(pizza.Id.Value);
            TestOrder(pizza, gotPizza);
        }

        private void PutTest()
        {
            if (Pizza.Id == null) return;
            Pizza.MenuItem = true;
           _pizzas.PutPizza(Pizza.Id.Value, Pizza);
           GetTest(Pizza);
        }

        private void PostTest()
        {
            var postedPizza = _pizzas.PostPizza(Pizza);
            Pizza = postedPizza;
            GetTest(Pizza);
        }

        public void TestOrder(Pizza expected, Pizza actual)
        {
            if (expected.Id == null || actual.Id == null) return;
            Assert.AreEqual(expected.Id.Value, actual.Id.Value);
            Assert.AreEqual(expected.MenuItem, actual.MenuItem);
        }
    }
}
