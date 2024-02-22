namespace bikesTest5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class moreColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bikes", "BikeFrame", c => c.Int(nullable: false));
            AddColumn("dbo.Bikes", "Weight", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bikes", "Weight");
            DropColumn("dbo.Bikes", "BikeFrame");
        }
    }
}
