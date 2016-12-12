using Anchovy.API.Service.Models;

namespace Anchovy.API.Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Anchovy.API.Service.DAL.AnchovyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Anchovy.API.Service.DAL.AnchovyContext context)
        {
            /*
            var thin = new Crust() {Cost = 6.00m, Id = 1, Name = "Thin"};
            var handTossed = new Crust() { Cost = 7.00m, Id = 2, Name = "Hand Tossed" };
            var deepDish = new Crust() { Cost = 8.00m, Id = 3, Name = "Deep Dish" };
            var chicago = new Crust() { Cost = 9.00m, Id = 4, Name = "Chicago Style" };

            context.Crusts.AddOrUpdate(x => x.Id, thin, handTossed, deepDish, chicago);

            var marinara = new Sauce() {Cost = 0.00m, Id = 1, Name = "Marinara"};
            var alfredo = new Sauce() { Cost = 1.00m, Id = 2, Name = "Alfredo" };
            var pesto = new Sauce() { Cost = 1.00m, Id = 3, Name = "Pesto" };
            var bbq = new Sauce() { Cost = 1.00m, Id = 4, Name = "Barbecue" };

            context.Sauces.AddOrUpdate(x => x.Id, marinara, alfredo, pesto, bbq);

            var small = new Size {Cost = 0.00m, Id = 1, Name = "Small"};
            var medium = new Size {Cost = 0.50m, Id = 2, Name = "Medium"};
            var large = new Size { Cost = 1.00m, Id = 3, Name = "Large" };
            var extraLarge = new Size { Cost = 1.50m, Id = 4, Name = "Extra Large" };

            context.Sizes.AddOrUpdate(x => x.Id, small, medium, large, extraLarge);

            var cheese = new Topping() {Cost = 0.00m, Id = 1, Name = "Cheese", LowLevel = 1000, Quantity = 10000};
            var pepperoni = new Topping() { Cost = 1.50m, Id = 2, Name = "Pepperoni", LowLevel = 1000, Quantity = 800 };
            var sausage = new Topping() { Cost = 1.50m, Id = 3, Name = "Sausage", LowLevel = 1000, Quantity = 10000 };
            var peppers = new Topping() { Cost = 1.50m, Id = 4, Name = "Green Pepper", LowLevel = 1000, Quantity = 10000 };
            var onions = new Topping() { Cost = 1.50m, Id = 5, Name = "Onion", LowLevel = 1000, Quantity = 10000 };
            var mushrooms = new Topping() { Cost = 1.50m, Id = 6, Name = "Mushroom", LowLevel = 1000, Quantity = 10000 };
            var pineapple = new Topping() { Cost = 1.50m, Id = 7, Name = "Pineapple", LowLevel = 1000, Quantity = 10000 };
            var anchovies = new Topping() { Cost = 2.00m, Id = 8, Name = "Anchovy", LowLevel = 5, Quantity = 0 };
            var bacon = new Topping() { Cost = 2.00m, Id = 9, Name = "Bacon", LowLevel = 300, Quantity = 200 };

            context.Toppings.AddOrUpdate(x => x.Id, cheese, pepperoni, sausage, peppers, onions, mushrooms, pineapple, anchovies, bacon);

            var pepperoni1 = new Pizza()
            {
                Crust = thin,
                CrustId = 1,
                Id = 1,
                MenuItem = true,
                Name = "Thin Small Pepperoni",
                Sauce = marinara,
                SauceId = 1,
                Size = small,
                SizeId = 1
            };

            var pepperoni2 = new Pizza()
            {
                Crust = thin,
                CrustId = 1,
                Id = 2,
                MenuItem = true,
                Name = "Thin Medium Pepperoni",
                Sauce = marinara,
                SauceId = 1,
                Size = medium,
                SizeId = 2
            };

            var pepperoni3 = new Pizza()
            {
                Crust = thin,
                CrustId = 1,
                Id = 3,
                MenuItem = true,
                Name = "Thin Large Pepperoni",
                Sauce = marinara,
                SauceId = 1,
                Size = large,
                SizeId = 3
            };

            var pepperoni4 = new Pizza()
            {
                Crust = thin,
                CrustId = 1,
                Id = 4,
                MenuItem = true,
                Name = "Thin Extra Large Pepperoni",
                Sauce = marinara,
                SauceId = 1,
                Size = extraLarge,
                SizeId = 4
            };

            var pepperoni5 = new Pizza()
            {
                Crust = handTossed,
                CrustId = 2,
                Id = 5,
                MenuItem = true,
                Name = "Hand Tossed Small Pepperoni",
                Sauce = marinara,
                SauceId = 1,
                Size = small,
                SizeId = 1
            };

            var pepperoni6 = new Pizza()
            {
                Crust = handTossed,
                CrustId = 2,
                Id = 6,
                MenuItem = true,
                Name = "Hand Tossed Medium Pepperoni",
                Sauce = marinara,
                SauceId = 1,
                Size = medium,
                SizeId = 2
            };

            var pepperoni7 = new Pizza()
            {
                Crust = handTossed,
                CrustId = 2,
                Id = 7,
                MenuItem = true,
                Name = "Hand Tossed Large Pepperoni",
                Sauce = marinara,
                SauceId = 1,
                Size = large,
                SizeId = 3
            };

            var pepperoni8 = new Pizza()
            {
                Crust = handTossed,
                CrustId = 2,
                Id = 8,
                MenuItem = true,
                Name = "Hand Tossed Extra Large Pepperoni",
                Sauce = marinara,
                SauceId = 1,
                Size = extraLarge,
                SizeId = 4
            };

            var pepperoni9 = new Pizza()
            {
                Crust = deepDish,
                CrustId = 3,
                Id = 9,
                MenuItem = true,
                Name = "Deep Dish Small Pepperoni",
                Sauce = marinara,
                SauceId = 1,
                Size = small,
                SizeId = 1
            };

            var pepperoni10 = new Pizza()
            {
                Crust = deepDish,
                CrustId = 3,
                Id = 10,
                MenuItem = true,
                Name = "Deep Dish Medium Pepperoni",
                Sauce = marinara,
                SauceId = 1,
                Size = medium,
                SizeId = 2
            };

            var pepperoni11 = new Pizza()
            {
                Crust = deepDish,
                CrustId = 3,
                Id = 11,
                MenuItem = true,
                Name = "Deep Dish Large Pepperoni",
                Sauce = marinara,
                SauceId = 1,
                Size = large,
                SizeId = 3
            };

            var pepperoni12 = new Pizza()
            {
                Crust = deepDish,
                CrustId = 3,
                Id = 12,
                MenuItem = true,
                Name = "Deep Dish Extra Large Pepperoni",
                Sauce = marinara,
                SauceId = 1,
                Size = extraLarge,
                SizeId = 4
            };

            var pepperoni13 = new Pizza()
            {
                Crust = chicago,
                CrustId = 4,
                Id = 13,
                MenuItem = true,
                Name = "Chicago Small Pepperoni",
                Sauce = marinara,
                SauceId = 1,
                Size = small,
                SizeId = 1
            };

            var pepperoni14 = new Pizza()
            {
                Crust = chicago,
                CrustId = 4,
                Id = 14,
                MenuItem = true,
                Name = "Chicago Medium Pepperoni",
                Sauce = marinara,
                SauceId = 1,
                Size = medium,
                SizeId = 2
            };

            var pepperoni15 = new Pizza()
            {
                Crust = chicago,
                CrustId = 4,
                Id = 15,
                MenuItem = true,
                Name = "Chicago Large Pepperoni",
                Sauce = marinara,
                SauceId = 1,
                Size = large,
                SizeId = 3
            };

            var pepperoni16 = new Pizza()
            {
                Crust = chicago,
                CrustId = 4,
                Id = 16,
                MenuItem = true,
                Name = "Chicago Extra Large Pepperoni",
                Sauce = marinara,
                SauceId = 1,
                Size = extraLarge,
                SizeId = 4
            };

            context.Pizzas.AddOrUpdate(x => x.Id, pepperoni1, pepperoni2, pepperoni3, pepperoni4, pepperoni5, pepperoni6, pepperoni7, pepperoni8, pepperoni9, pepperoni10, pepperoni11, pepperoni12, pepperoni13, pepperoni14, pepperoni15, pepperoni16);

            var pep1 = new PizzaTopping() {Id = 1, Pizza = pepperoni1, PizzaId = 1, Topping = cheese, ToppingId = 1};
            var pep2 = new PizzaTopping() { Id = 2, Pizza = pepperoni1, PizzaId = 1, Topping = pepperoni, ToppingId = 2 };
            var pep3 = new PizzaTopping() { Id = 3, Pizza = pepperoni2, PizzaId = 2, Topping = cheese, ToppingId = 1 };
            var pep4 = new PizzaTopping() { Id = 4, Pizza = pepperoni2, PizzaId = 2, Topping = pepperoni, ToppingId = 2 };
            var pep5 = new PizzaTopping() { Id = 5, Pizza = pepperoni3, PizzaId = 3, Topping = cheese, ToppingId = 1 };
            var pep6 = new PizzaTopping() { Id = 6, Pizza = pepperoni3, PizzaId = 3, Topping = pepperoni, ToppingId = 2 };
            var pep7 = new PizzaTopping() { Id = 7, Pizza = pepperoni4, PizzaId = 4, Topping = cheese, ToppingId = 1 };
            var pep8 = new PizzaTopping() { Id = 8, Pizza = pepperoni4, PizzaId = 4, Topping = pepperoni, ToppingId = 2 };
            var pep9 = new PizzaTopping() { Id = 9, Pizza = pepperoni5, PizzaId = 5, Topping = cheese, ToppingId = 1 };
            var pep10 = new PizzaTopping() { Id = 10, Pizza = pepperoni5, PizzaId = 5, Topping = pepperoni, ToppingId = 2 };
            var pep11 = new PizzaTopping() { Id = 11, Pizza = pepperoni6, PizzaId = 6, Topping = cheese, ToppingId = 1 };
            var pep12 = new PizzaTopping() { Id = 12, Pizza = pepperoni6, PizzaId = 6, Topping = pepperoni, ToppingId = 2 };
            var pep13 = new PizzaTopping() { Id = 13, Pizza = pepperoni7, PizzaId = 7, Topping = cheese, ToppingId = 1 };
            var pep14 = new PizzaTopping() { Id = 14, Pizza = pepperoni7, PizzaId = 7, Topping = pepperoni, ToppingId = 2 };
            var pep15 = new PizzaTopping() { Id = 15, Pizza = pepperoni8, PizzaId = 8, Topping = cheese, ToppingId = 1 };
            var pep16 = new PizzaTopping() { Id = 16, Pizza = pepperoni8, PizzaId = 8, Topping = pepperoni, ToppingId = 2 };
            var pep17 = new PizzaTopping() { Id = 17, Pizza = pepperoni9, PizzaId = 9, Topping = cheese, ToppingId = 1 };
            var pep18 = new PizzaTopping() { Id = 18, Pizza = pepperoni9, PizzaId = 9, Topping = pepperoni, ToppingId = 2 };
            var pep19 = new PizzaTopping() { Id = 19, Pizza = pepperoni10, PizzaId = 10, Topping = cheese, ToppingId = 1 };
            var pep20 = new PizzaTopping() { Id = 20, Pizza = pepperoni10, PizzaId = 10, Topping = pepperoni, ToppingId = 2 };
            var pep21 = new PizzaTopping() { Id = 21, Pizza = pepperoni11, PizzaId = 11, Topping = cheese, ToppingId = 1 };
            var pep22 = new PizzaTopping() { Id = 22, Pizza = pepperoni11, PizzaId = 11, Topping = pepperoni, ToppingId = 2 };
            var pep23 = new PizzaTopping() { Id = 23, Pizza = pepperoni12, PizzaId = 12, Topping = cheese, ToppingId = 1 };
            var pep24 = new PizzaTopping() { Id = 24, Pizza = pepperoni12, PizzaId = 12, Topping = pepperoni, ToppingId = 2 };
            var pep25 = new PizzaTopping() { Id = 25, Pizza = pepperoni13, PizzaId = 13, Topping = cheese, ToppingId = 1 };
            var pep26 = new PizzaTopping() { Id = 26, Pizza = pepperoni13, PizzaId = 13, Topping = pepperoni, ToppingId = 2 };
            var pep27 = new PizzaTopping() { Id = 27, Pizza = pepperoni14, PizzaId = 14, Topping = cheese, ToppingId = 1 };
            var pep28 = new PizzaTopping() { Id = 28, Pizza = pepperoni14, PizzaId = 14, Topping = pepperoni, ToppingId = 2 };
            var pep29 = new PizzaTopping() { Id = 29, Pizza = pepperoni15, PizzaId = 15, Topping = cheese, ToppingId = 1 };
            var pep30 = new PizzaTopping() { Id = 30, Pizza = pepperoni15, PizzaId = 15, Topping = pepperoni, ToppingId = 2 };
            var pep31 = new PizzaTopping() { Id = 31, Pizza = pepperoni16, PizzaId = 16, Topping = cheese, ToppingId = 1 };
            var pep32 = new PizzaTopping() { Id = 32, Pizza = pepperoni16, PizzaId = 16, Topping = pepperoni, ToppingId = 2 };

            context.PizzaToppings.AddOrUpdate(x => x.Id, pep1, pep2, pep3, pep4, pep5, pep6, pep7, pep8, pep9, pep10, pep11, pep12, pep13, pep14, pep15, pep16, pep17, pep18, pep19, pep20, pep21, pep22, pep23, pep24, pep25, pep26, pep27, pep28, pep29, pep30, pep31, pep32);

            var ml1 = new MenuListing() {Cost = 5.00m, Id = 1, Name = "Small Wings", Size = small, SizeId = 1};
            var ml2 = new MenuListing() {Cost = 5.00m, Id = 2, Name = "Medium Wings", Size = medium, SizeId = 2};
            var ml3 = new MenuListing() { Cost = 2.00m, Id = 3, Name = "Small Fries", Size = small, SizeId = 1 };
            var ml4 = new MenuListing() { Cost = 2.00m, Id = 4, Name = "Medium Fries", Size = medium, SizeId = 2 };
            context.MenuListings.AddOrUpdate(x => x.Id, ml1,ml2, ml3, ml4);

            var noaht = new Manager()
            {
                Address = "2524 S 12th Street",
                City = "Sheboygan",
                Email = "noah.trilling@gmail.com",
                FirstName = "Noah",
                Id = 1,
                LastName = "Trilling",
                MiddleName = "James",
                Password = "admin",
                Phone = "9206272984",
                Salary = 40000.00m,
                State = "WI",
                Username = "noaht"
            };
             
            context.Managers.AddOrUpdate(x => x.Id, noaht);

            var homer = new Cook()
            {
                Address = "123 Fake Street",
                City = "Springfield",
                Email = "noah.trilling@gmail.com",
                FirstName = "Homer",
                HourlyWage = 15.00m,
                Id = 1,
                LastName = "Simpson",
                Manager = noaht,
                ManagerId = 1,
                MiddleName = "Jay",
                Password = "admin",
                State = "WI",
                Phone = "9206272984",
                Username = "homers",
                PieceworkRate = 0.25m
            };

            context.Cooks.AddOrUpdate(x => x.Id, homer);

            var shift = new Shift()
            {
                Cook = homer,
                CookId = 1,
                StartTime = DateTimeOffset.UtcNow.AddHours(-8),
                EndTime = DateTimeOffset.UtcNow
            };

            context.Shifts.AddOrUpdate(x => x.Id, shift);

            var cbg = new Customer()
            {
                Address = "Android's Dungeon",
                City = "Springfield",
                Email = "noah.trilling@gmail.com",
                FirstName = "Comic",
                Id = 1,
                LastName = "Guy",
                MiddleName = "Book",
                Password = "admin",
                Phone = "9206272984",
                SignUpDate = DateTimeOffset.UtcNow,
                State = "WI",
                Username = "comicg"
            };

            context.Customers.AddOrUpdate(x => x.Id, cbg);

            var line1 = new Line() {Id = 1, MenuListing = null, MenuListingId = null, Pizza = pepperoni1, PizzaId = 1,Quantity = 1};
            var line2 = new Line() { Id = 1, MenuListing = null, MenuListingId = null, Pizza = pepperoni2, PizzaId = 2, Quantity = 1 };
            var line3 = new Line() { Id = 1, MenuListing = null, MenuListingId = null, Pizza = pepperoni3, PizzaId = 3, Quantity = 1 };
            var line4 = new Line() { Id = 1, MenuListing = null, MenuListingId = null, Pizza = pepperoni4, PizzaId = 4, Quantity = 1 };
            var line5 = new Line() { Id = 1, MenuListing = null, MenuListingId = null, Pizza = pepperoni5, PizzaId = 5, Quantity = 1 };
            var line6 = new Line() { Id = 1, MenuListing = null, MenuListingId = null, Pizza = pepperoni6, PizzaId = 6, Quantity = 1 };

            context.Lines.AddOrUpdate(x => x.Id, line1, line2, line3, line4, line5, line6);

            var order1 = new Order()
            {
                CancelledTimeStamp = DateTimeOffset.UtcNow,
                ClaimedTimeStamp = null,
                CompletedTimeStamp = null,
                Cook = null,
                CookId = null,
                Customer = cbg,
                CustomerId = 1,
                Id = 1,
                OrderedTimeStamp = DateTimeOffset.UtcNow.AddHours(-20),
                OrderStatus = OrderStatus.Cancelled
            };
            var order2 = new Order()
            {
                CancelledTimeStamp = null,
                ClaimedTimeStamp = DateTimeOffset.UtcNow.AddHours(-18),
                CompletedTimeStamp = DateTimeOffset.UtcNow,
                Cook = homer,
                CookId = 1,
                Customer = cbg,
                CustomerId = 1,
                Id = 2,
                OrderedTimeStamp = DateTimeOffset.UtcNow.AddHours(-19),
                OrderStatus = OrderStatus.Completed
            };
            var order3 = new Order()
            {
                CancelledTimeStamp = null,
                ClaimedTimeStamp = null,
                CompletedTimeStamp = null,
                Cook = null,
                CookId = null,
                Customer = cbg,
                CustomerId = 1,
                Id = 3,
                OrderedTimeStamp = DateTimeOffset.UtcNow.AddHours(-1),
                OrderStatus = OrderStatus.Ordered
            };

            context.Orders.AddOrUpdate(x => x.Id, order1, order2, order3);

            var ol1 = new OrderLine() {Id = 1, Line = line1, LineId = 1, Order = order1, OrderId = 1};
            var ol2 = new OrderLine() { Id = 2, Line = line1, LineId = 2, Order = order1, OrderId = 1 };
            var ol3 = new OrderLine() { Id = 3, Line = line2, LineId = 3, Order = order2, OrderId = 2 };
            var ol4 = new OrderLine() { Id = 4, Line = line2, LineId = 4, Order = order2, OrderId = 2 };
            var ol5 = new OrderLine() { Id = 5, Line = line3, LineId = 5, Order = order3, OrderId = 3 };
            var ol6 = new OrderLine() { Id = 6, Line = line3, LineId = 6, Order = order3, OrderId = 3 };

            context.OrderLines.AddOrUpdate(x => x.Id, ol1, ol2, ol3, ol4, ol5, ol6);






            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            */
        }
    }
}
