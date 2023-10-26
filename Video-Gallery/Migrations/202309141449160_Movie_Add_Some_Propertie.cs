namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Movie_Add_Some_Propertie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MovieType", c => c.String());
            AddColumn("dbo.Movies", "ReleasedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "AddDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "NumberOfStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberOfStock");
            DropColumn("dbo.Movies", "AddDate");
            DropColumn("dbo.Movies", "ReleasedDate");
            DropColumn("dbo.Movies", "MovieType");
        }
    }
}
