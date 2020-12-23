namespace eRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StatusReservaModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StatusReservas",
                c => new
                    {
                        StatusReserva_id = c.Int(nullable: false, identity: true),
                        Estado_reserva = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.StatusReserva_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StatusReservas");
        }
    }
}
