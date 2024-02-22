namespace bikesTest5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bikes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bikes",
                c => new
                    {
                        BikeId = c.Int(nullable: false, identity: true),
                        BikeName = c.String(),
                        Color = c.String(),
                        BikeYear = c.DateTime(nullable: false),
                        BikeSize = c.String(),
                    })
                .PrimaryKey(t => t.BikeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bikes");
        }
    }
}
