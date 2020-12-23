namespace eRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReservaModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        Reserva_id = c.Int(nullable: false, identity: true),
                        data_inicio = c.DateTime(nullable: false),
                        data_fim = c.DateTime(nullable: false),
                        Cliente_id = c.Int(nullable: false),
                        StatusReserva_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Reserva_id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_id, cascadeDelete: true)
                .ForeignKey("dbo.StatusReservas", t => t.StatusReserva_id, cascadeDelete: true)
                .Index(t => t.Cliente_id)
                .Index(t => t.StatusReserva_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservas", "StatusReserva_id", "dbo.StatusReservas");
            DropForeignKey("dbo.Reservas", "Cliente_id", "dbo.Clientes");
            DropIndex("dbo.Reservas", new[] { "StatusReserva_id" });
            DropIndex("dbo.Reservas", new[] { "Cliente_id" });
            DropTable("dbo.Reservas");
        }
    }
}
