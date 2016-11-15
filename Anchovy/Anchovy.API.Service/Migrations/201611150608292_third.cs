namespace Anchovy.API.Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        HourlyWage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PieceworkRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ManagerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Managers", t => t.ManagerId, cascadeDelete: true)
                .Index(t => t.ManagerId);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Crusts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        SignUpDate = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Lines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuListingId = c.Int(),
                        PizzaId = c.Int(),
                        Quantity = c.Int(nullable: false),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuListings", t => t.MenuListingId)
                .ForeignKey("dbo.Pizzas", t => t.PizzaId)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.MenuListingId)
                .Index(t => t.PizzaId)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.MenuListings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SizeId = c.Int(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sizes", t => t.SizeId, cascadeDelete: true)
                .Index(t => t.SizeId);
            
            CreateTable(
                "dbo.Sizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pizzas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CrustId = c.Int(nullable: false),
                        SauceId = c.Int(nullable: false),
                        MenuItem = c.Boolean(nullable: false),
                        SizeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Crusts", t => t.CrustId, cascadeDelete: true)
                .ForeignKey("dbo.Sauces", t => t.SauceId, cascadeDelete: true)
                .ForeignKey("dbo.Sizes", t => t.SizeId, cascadeDelete: true)
                .Index(t => t.CrustId)
                .Index(t => t.SauceId)
                .Index(t => t.SizeId);
            
            CreateTable(
                "dbo.Sauces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Toppings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        LowLevel = c.Int(nullable: false),
                        Pizza_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pizzas", t => t.Pizza_Id)
                .Index(t => t.Pizza_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        CookId = c.Int(),
                        OrderedTimeStamp = c.DateTimeOffset(precision: 7),
                        ClaimedTimeStamp = c.DateTimeOffset(precision: 7),
                        CompletedTimeStamp = c.DateTimeOffset(precision: 7),
                        CancelledTimeStamp = c.DateTimeOffset(precision: 7),
                        OrderStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cooks", t => t.CookId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.CookId);
            
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CookId = c.Int(nullable: false),
                        StartTime = c.DateTimeOffset(nullable: false, precision: 7),
                        EndTime = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cooks", t => t.CookId, cascadeDelete: true)
                .Index(t => t.CookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shifts", "CookId", "dbo.Cooks");
            DropForeignKey("dbo.Lines", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Orders", "CookId", "dbo.Cooks");
            DropForeignKey("dbo.Lines", "PizzaId", "dbo.Pizzas");
            DropForeignKey("dbo.Toppings", "Pizza_Id", "dbo.Pizzas");
            DropForeignKey("dbo.Pizzas", "SizeId", "dbo.Sizes");
            DropForeignKey("dbo.Pizzas", "SauceId", "dbo.Sauces");
            DropForeignKey("dbo.Pizzas", "CrustId", "dbo.Crusts");
            DropForeignKey("dbo.Lines", "MenuListingId", "dbo.MenuListings");
            DropForeignKey("dbo.MenuListings", "SizeId", "dbo.Sizes");
            DropForeignKey("dbo.Cooks", "ManagerId", "dbo.Managers");
            DropIndex("dbo.Shifts", new[] { "CookId" });
            DropIndex("dbo.Orders", new[] { "CookId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Toppings", new[] { "Pizza_Id" });
            DropIndex("dbo.Pizzas", new[] { "SizeId" });
            DropIndex("dbo.Pizzas", new[] { "SauceId" });
            DropIndex("dbo.Pizzas", new[] { "CrustId" });
            DropIndex("dbo.MenuListings", new[] { "SizeId" });
            DropIndex("dbo.Lines", new[] { "Order_Id" });
            DropIndex("dbo.Lines", new[] { "PizzaId" });
            DropIndex("dbo.Lines", new[] { "MenuListingId" });
            DropIndex("dbo.Cooks", new[] { "ManagerId" });
            DropTable("dbo.Shifts");
            DropTable("dbo.Orders");
            DropTable("dbo.Toppings");
            DropTable("dbo.Sauces");
            DropTable("dbo.Pizzas");
            DropTable("dbo.Sizes");
            DropTable("dbo.MenuListings");
            DropTable("dbo.Lines");
            DropTable("dbo.Customers");
            DropTable("dbo.Crusts");
            DropTable("dbo.Managers");
            DropTable("dbo.Cooks");
        }
    }
}
