using System;
using Anchovy.API.Service.Models;
using System.Data.Entity;

namespace Anchovy.API.Service.DAL
{
    public class AnchovyContext : DbContext
    {
        public DbSet<Cook> Cooks { get; set; }
        public DbSet<Crust> Crusts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<MenuListing> MenuListings { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Sauce> Sauces { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public AnchovyContext() : base("AnchovyContext")
        {
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
        }


    }
}