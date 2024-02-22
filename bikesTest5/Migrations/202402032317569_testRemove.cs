namespace bikesTest5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testRemove : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Bikes", "Price");
            DropColumn("dbo.Bikes", "total");
            DropColumn("dbo.Bikes", "Price2");
            DropColumn("dbo.Bikes", "total2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bikes", "total2", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Bikes", "Price2", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Bikes", "total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Bikes", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
