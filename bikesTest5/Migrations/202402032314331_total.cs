namespace bikesTest5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class total : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bikes", "total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bikes", "total");
        }
    }
}
