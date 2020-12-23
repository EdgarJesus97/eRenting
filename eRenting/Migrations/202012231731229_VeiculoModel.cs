namespace eRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VeiculoModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Veiculos",
                c => new
                    {
                        Veiculo_id = c.Int(nullable: false, identity: true),
                        Matricula = c.String(nullable: false, maxLength: 50),
                        Marca = c.String(nullable: false, maxLength: 250),
                        Modelo = c.String(nullable: false, maxLength: 250),
                        Cilindrada = c.Int(nullable: false),
                        Km = c.Int(nullable: false),
                        Nmotor = c.Int(nullable: false),
                        Cor = c.String(nullable: false, maxLength: 50),
                        Nportas = c.Int(nullable: false),
                        Ano_Fabrico = c.Int(nullable: false),
                        Locatacao = c.Int(nullable: false),
                        Observacoes = c.String(nullable: true, maxLength: 250),
                        preco_dia = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Veiculo_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Veiculos");
        }
    }
}
