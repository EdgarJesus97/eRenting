namespace eRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReserva_FKVeiculo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservas", "Veiculo_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Reservas", "Veiculo_id");
            AddForeignKey("dbo.Reservas", "Veiculo_id", "dbo.Veiculos", "Veiculo_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservas", "Veiculo_id", "dbo.Veiculos");
            DropIndex("dbo.Reservas", new[] { "Veiculo_id" });
            DropColumn("dbo.Reservas", "Veiculo_id");
        }
    }
}
