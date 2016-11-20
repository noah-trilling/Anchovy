namespace Anchovy.API.Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuListings", t => t.MenuListingId)
                .ForeignKey("dbo.Pizzas", t => t.PizzaId)
                .Index(t => t.MenuListingId)
                .Index(t => t.PizzaId);
            
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
                "dbo.OrderLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        LineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lines", t => t.LineId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.LineId);
            
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
                "dbo.PizzaToppings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PizzaId = c.Int(nullable: false),
                        ToppingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pizzas", t => t.PizzaId, cascadeDelete: true)
                .ForeignKey("dbo.Toppings", t => t.ToppingId, cascadeDelete: true)
                .Index(t => t.PizzaId)
                .Index(t => t.ToppingId);
            
            CreateTable(
                "dbo.Toppings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        LowLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
            DropForeignKey("dbo.PizzaToppings", "ToppingId", "dbo.Toppings");
            DropForeignKey("dbo.PizzaToppings", "PizzaId", "dbo.Pizzas");
            DropForeignKey("dbo.OrderLines", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Orders", "CookId", "dbo.Cooks");
            DropForeignKey("dbo.OrderLines", "LineId", "dbo.Lines");
            DropForeignKey("dbo.Lines", "PizzaId", "dbo.Pizzas");
            DropForeignKey("dbo.Pizzas", "SizeId", "dbo.Sizes");
            DropForeignKey("dbo.Pizzas", "SauceId", "dbo.Sauces");
            DropForeignKey("dbo.Pizzas", "CrustId", "dbo.Crusts");
            DropForeignKey("dbo.Lines", "MenuListingId", "dbo.MenuListings");
            DropForeignKey("dbo.MenuListings", "SizeId", "dbo.Sizes");
            DropForeignKey("dbo.Cooks", "ManagerId", "dbo.Managers");
            DropIndex("dbo.Shifts", new[] { "CookId" });
            DropIndex("dbo.PizzaToppings", new[] { "ToppingId" });
            DropIndex("dbo.PizzaToppings", new[] { "PizzaId" });
            DropIndex("dbo.Orders", new[] { "CookId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.OrderLines", new[] { "LineId" });
            DropIndex("dbo.OrderLines", new[] { "OrderId" });
            DropIndex("dbo.Pizzas", new[] { "SizeId" });
            DropIndex("dbo.Pizzas", new[] { "SauceId" });
            DropIndex("dbo.Pizzas", new[] { "CrustId" });
            DropIndex("dbo.MenuListings", new[] { "SizeId" });
            DropIndex("dbo.Lines", new[] { "PizzaId" });
            DropIndex("dbo.Lines", new[] { "MenuListingId" });
            DropIndex("dbo.Cooks", new[] { "ManagerId" });
            DropTable("dbo.Shifts");
            DropTable("dbo.Toppings");
            DropTable("dbo.PizzaToppings");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderLines");
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
