namespace Moren.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixYearlyToAnnualInMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Annual' WHERE Id = 4");
        }

        public override void Down()
        {
        }
    }
}
