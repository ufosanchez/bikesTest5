namespace bikesTest5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testDecimals : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bikes", "Price2", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Bikes", "total2", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bikes", "total2");
            DropColumn("dbo.Bikes", "Price2");
        }
    }
}
