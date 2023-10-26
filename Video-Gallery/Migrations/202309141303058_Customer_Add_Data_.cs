namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customer_Add_Data_ : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Customers( Name, IsSubscribedToNewsletter, MembershipTypeId) Values ('Tusar',0,1)");
            Sql("Insert into Customers( Name, IsSubscribedToNewsletter, MembershipTypeId) Values ('Singh',1,2)");
        }
        
        public override void Down()
        {
        }
    }
}
