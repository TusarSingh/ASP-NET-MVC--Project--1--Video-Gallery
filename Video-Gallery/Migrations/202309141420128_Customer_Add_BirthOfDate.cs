namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customer_Add_BirthOfDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthOfDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthOfDate");
        }
    }
}
