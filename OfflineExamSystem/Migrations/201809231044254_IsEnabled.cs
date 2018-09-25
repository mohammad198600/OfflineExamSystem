namespace OfflineExamSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsEnabled : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "IsEnabled", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "IsEnabled");
        }
    }
}
