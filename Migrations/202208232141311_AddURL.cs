namespace CodeFirstAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddURL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "URL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "URL");
        }
    }
}
