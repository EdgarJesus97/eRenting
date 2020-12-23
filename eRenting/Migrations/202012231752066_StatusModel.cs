namespace eRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StatusModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Estado_id = c.Int(nullable: false, identity: true),
                        Estado = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Estado_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Status");
        }
    }
}
