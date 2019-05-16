namespace Moren.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WritePendingModel : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.AspNetUsers", "DrivingLicense", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime());
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.AspNetUsers", "Phone");
           // DropColumn("dbo.AspNetUsers", "DrivingLicense");
        }
    }
}
