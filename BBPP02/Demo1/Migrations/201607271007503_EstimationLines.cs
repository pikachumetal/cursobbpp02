namespace Demo1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EstimationLines : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EstimationLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Long(nullable: false),
                        Product_Id = c.Int(),
                        Estimation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Estimations", t => t.Estimation_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Estimation_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EstimationLines", "Estimation_Id", "dbo.Estimations");
            DropForeignKey("dbo.EstimationLines", "Product_Id", "dbo.Products");
            DropIndex("dbo.EstimationLines", new[] { "Estimation_Id" });
            DropIndex("dbo.EstimationLines", new[] { "Product_Id" });
            DropTable("dbo.EstimationLines");
        }
    }
}
