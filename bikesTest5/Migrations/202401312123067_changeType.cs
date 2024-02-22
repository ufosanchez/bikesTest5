namespace bikesTest5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bikes", "BikeFrame", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bikes", "BikeFrame", c => c.Int(nullable: false));
        }
    }
}
