namespace WebApiPracData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoryandseeding : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryName", c => c.String());
            DropColumn("dbo.Categories", "Administration");
            DropColumn("dbo.Categories", "WebDevelopment");
            DropColumn("dbo.Categories", "WebDesign");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "WebDesign", c => c.String());
            AddColumn("dbo.Categories", "WebDevelopment", c => c.String());
            AddColumn("dbo.Categories", "Administration", c => c.String());
            DropColumn("dbo.Categories", "CategoryName");
        }
    }
}
