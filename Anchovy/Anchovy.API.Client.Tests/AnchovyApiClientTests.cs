using System;
using System.Collections.Generic;
using Anchovy.API.Client.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anchovy.API.Client.Tests
{
    [TestClass]
    public class AnchovyApiClientTests
    {
        protected AnchovyAPIService Service;

        //Noah's classes to integration test

        public Line Line;
        public IList<Line> OrderLines;

        public IPizzas Pizzas;
        public Pizza Pizza;

        public IOrders Orders;
        public Order Order;
        public Customer Customer;
        public Cook Cook;
        public Manager Manager;

        public MenuListing MenuListing;
        public Size Size;
        public Crust Crust;
        public Sauce Sauce;
        public Topping Topping;
        public IList<Topping> Toppings;



        [TestInitialize]
        public void TestInitialize()
        {
            Service = new AnchovyAPIService();

            Size = new Size
            {
                Cost = 1.00,
                Name = "Extra Large"
            };

            Crust = new Crust
            {
                Cost = 10.00,
                Name = "Deep Dish"
            };

            Sauce = new Sauce
            {
                Cost = 0.00,
                Name = "Marinara"
            };

            Topping = new Topping
            {
                Cost = 1.00,
                LowLevel = 100,
                Quantity = 500
            };

            Manager = new Manager
            {
                Address = "123 Fake Street",
                City = "Springfield",
                Email = "burns@nuclearplant.gov",
                FirstName = "Montgomery",
                LastName = "Burns",
                MiddleName = "Bobo"
            };

            Cook = new Cook
            {
                Address = "123 Fake Street",
                City = "Springfield",
                Email = "burns@nuclearplant.gov",
                FirstName = "Homer",
                LastName = "Simpson",
                MiddleName = "Jay",
                HourlyWage = 60000,
                Manager = this.Manager
            };

            Customer = new Customer
            {
                Address = "123 Fake Street",
                City = "Springfield",
                Email = "burns@nuclearplant.gov",
                FirstName = "Homer",
                LastName = "Simpson",
                MiddleName = "Jay",
                SignUpDate = DateTimeOffset.Now
            };

            MenuListing = new MenuListing
            {
                Cost = 1.00,
                Name = "Wings",
                Size = this.Size,
            };

            Pizza = new Pizza
            {
                Crust = this.Crust,
                MenuItem = false,
                Name = "Custom",
                Sauce = this.Sauce,
                Size = this.Size,
                Toppings = this.Toppings
            };

            Line = new Line
            {
                MenuListing = this.MenuListing,
                Pizza = this.Pizza,
                Quantity = 50
            };

            OrderLines = new List<Line> {Line};
            Order = new Order
            {
                OrderedTimeStamp = DateTimeOffset.UtcNow,
                CancelledTimeStamp = DateTimeOffset.UtcNow,
                ClaimedTimeStamp = DateTimeOffset.UtcNow,
                CompletedTimeStamp = DateTimeOffset.UtcNow,
                Cook = this.Cook,
                Customer = this.Customer,
                Lines = OrderLines,
                OrderStatus = 4
            };

        }
        
    }
}
