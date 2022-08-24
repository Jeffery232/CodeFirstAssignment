namespace CodeFirstAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        CompanyAddress = c.Int(nullable: false),
                        ProductType = c.Int(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Company_CompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Companies", t => t.Company_CompanyId)
                .Index(t => t.Company_CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Company_CompanyId", "dbo.Companies");
            DropIndex("dbo.Products", new[] { "Company_CompanyId" });
            DropTable("dbo.Products");
            DropTable("dbo.Companies");
        }
    }
}
