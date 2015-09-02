namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedATable : DbMigration
    {
        public override void Up()
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
        
        public override void Down()
        {
            DropTable("dbo.oktodelete");
        }
    }
}
