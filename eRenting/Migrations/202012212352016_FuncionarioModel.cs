namespace eRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FuncionarioModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        Funcionario_id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 120),
                        Contacto = c.Int(nullable: false),
                        Email = c.String(),
                        Empresa_Empresa_id = c.Int(),
                    })
                .PrimaryKey(t => t.Funcionario_id)
                .ForeignKey("dbo.Empresas", t => t.Empresa_Empresa_id)
                .Index(t => t.Empresa_Empresa_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Funcionarios", "Empresa_Empresa_id", "dbo.Empresas");
            DropIndex("dbo.Funcionarios", new[] { "Empresa_Empresa_id" });
            DropTable("dbo.Funcionarios");
        }
    }
}
