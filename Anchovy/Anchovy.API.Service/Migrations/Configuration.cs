using Anchovy.API.Service.Models;

namespace Anchovy.API.Service.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Anchovy.API.Service.DAL.AnchovyContext>
    {
        public Configuration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
            ContextKey = "Anchovy.API.Service.DAL.AnchovyContext";
        }

        protected override void Seed(Anchovy.API.Service.DAL.AnchovyContext context)
        {
            var cheese = new Topping() {Id = 1, Cost = 1.00m, Name = "Cheese", LowLevel = 50, Quantity = 1000};
            var pepperoni = new Topping() {Id = 2, Cost = 1.50m, Name = "Pepperoni", LowLevel = 25, Quantity = 250};
            var sausage = new Topping() {Id = 3, Cost = 1.50m, Name = "Italian Sausage", LowLevel = 25, Quantity = 25};
            var bacon = new Topping() {Id = 4, Cost = 1.50m, Name = "Bacon", LowLevel = 25, Quantity = 0};
            var anchovies = new Topping() {Id = 5, Cost = 2.00m, Name = "Anchovies", LowLevel = 5, Quantity = 4};
            var pineapple = new Topping() {Id = 6, Cost = 1.00m, Name = "Pineapple", LowLevel = 5, Quantity = 10};
            var pepper = new Topping() {Id = 7, Cost = 1.00m, Name = "Green Pepper", LowLevel = 15, Quantity = 30};
            var olives = new Topping() {Id = 8, Cost = 1.50m, Name = "Black Olive", LowLevel = 10, Quantity = 30};
            var onion = new Topping() {Id = 9, Cost = 1.00m, Name = "Red Onion", LowLevel = 15, Quantity = 40};

            context.Crusts.AddOrUpdate(_ => _.Id
            , new Crust() {Id = 1, Cost = 5.00m, Name = "Thin Crust"}
            , new Crust() {Id = 2, Cost = 7.00m, Name = "Hand Tossed Crust"}
            , new Crust() {Id = 3, Cost = 9.00m, Name = "Pan Crust"}
            , new Crust() {Id = 4, Cost = 11.00m, Name = "Deep Dish Crust"});
            context.Sauces.AddOrUpdate(_ => _.Id
            , new Sauce() {Id = 1, Cost = 0.00m, Name = "Marinara Sauce"}
            , new Sauce() {Id = 2, Cost = 1.00m, Name = "Alfredo Sauce"}
            , new Sauce() {Id = 3, Cost = 1.00m, Name = "Pesto Sauce"}
            , new Sauce() {Id = 4, Cost = 1.00m, Name = "Barbeque Sauce"});
            context.Toppings.AddOrUpdate(_ => _.Id
            , cheese
            , pepperoni
            , sausage
            , bacon
            , anchovies
            , pineapple
            , pepper
            , olives
            , onion);
            context.Sizes.AddOrUpdate(_ => _.Id);
            context.MenuListings.AddOrUpdate(_ => _.Id);
            context.Pizzas.AddOrUpdate(_ => _.Id);
            context.Lines.AddOrUpdate(_ => _.Id);
            context.Managers.AddOrUpdate(_ => _.Id);
            context.Customers.AddOrUpdate(_ => _.Id);
            context.Cooks.AddOrUpdate(_ => _.Id);
            context.Shifts.AddOrUpdate(_ => _.Id);
            context.Orders.AddOrUpdate(_ => _.Id);
        }
    }
}
