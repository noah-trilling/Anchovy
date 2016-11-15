namespace Anchovy.API.Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class manytomany : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Toppings", "Pizza_Id", "dbo.Pizzas");
            DropIndex("dbo.Toppings", new[] { "Pizza_Id" });
            CreateTable(
                "dbo.ToppingPizzas",
                c => new
                    {
                        Topping_Id = c.Int(nullable: false),
                        Pizza_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Topping_Id, t.Pizza_Id })
                .ForeignKey("dbo.Toppings", t => t.Topping_Id, cascadeDelete: true)
                .ForeignKey("dbo.Pizzas", t => t.Pizza_Id, cascadeDelete: true)
                .Index(t => t.Topping_Id)
                .Index(t => t.Pizza_Id);
            
            DropColumn("dbo.Toppings", "Pizza_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Toppings", "Pizza_Id", c => c.Int());
            DropForeignKey("dbo.ToppingPizzas", "Pizza_Id", "dbo.Pizzas");
            DropForeignKey("dbo.ToppingPizzas", "Topping_Id", "dbo.Toppings");
            DropIndex("dbo.ToppingPizzas", new[] { "Pizza_Id" });
            DropIndex("dbo.ToppingPizzas", new[] { "Topping_Id" });
            DropTable("dbo.ToppingPizzas");
            CreateIndex("dbo.Toppings", "Pizza_Id");
            AddForeignKey("dbo.Toppings", "Pizza_Id", "dbo.Pizzas", "Id");
        }
    }
}
