namespace bikesTest5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class anotherDecimal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bikes", "YourDecimalProperty", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bikes", "YourDecimalProperty");
        }
    }
}
