namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployeeLanguage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Language", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Language");
        }
    }
}
