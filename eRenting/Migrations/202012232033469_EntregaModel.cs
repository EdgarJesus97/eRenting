namespace eRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntregaModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entregas",
                c => new
                    {
                        Entrega_id = c.Int(nullable: false, identity: true),
                        Defeitos = c.String(maxLength: 250),
                        Km_iniciais = c.Int(nullable: false),
                        Nivel_deposito = c.Int(nullable: false),
                        Funcionario_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Entrega_id)
                .ForeignKey("dbo.Funcionarios", t => t.Funcionario_id, cascadeDelete: true)
                .Index(t => t.Funcionario_id);
            
            AlterColumn("dbo.Veiculos", "Observacoes", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entregas", "Funcionario_id", "dbo.Funcionarios");
            DropIndex("dbo.Entregas", new[] { "Funcionario_id" });
            AlterColumn("dbo.Veiculos", "Observacoes", c => c.String(nullable: false, maxLength: 250));
            DropTable("dbo.Entregas");
        }
    }
}
