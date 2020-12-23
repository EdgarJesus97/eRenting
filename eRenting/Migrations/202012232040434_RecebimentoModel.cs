namespace eRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecebimentoModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recebimentos",
                c => new
                    {
                        Recebimento_id = c.Int(nullable: false, identity: true),
                        Defeitos = c.String(maxLength: 250),
                        Km_finais = c.Int(nullable: false),
                        Nivel_deposito = c.Int(nullable: false),
                        Funcionario_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Recebimento_id)
                .ForeignKey("dbo.Funcionarios", t => t.Funcionario_id, cascadeDelete: true)
                .Index(t => t.Funcionario_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recebimentos", "Funcionario_id", "dbo.Funcionarios");
            DropIndex("dbo.Recebimentos", new[] { "Funcionario_id" });
            DropTable("dbo.Recebimentos");
        }
    }
}
