namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DroppedATable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.oktodelete");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.oktodelete",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SomeColum = c.String(),
                        Andre = c.String(),
                        Class = c.String(),
                        Today = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
