namespace eRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmpresasCollection3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Empresas", "Empresa_Empresa_id", "dbo.Empresas");
            DropForeignKey("dbo.Funcionarios", "Empresa_Empresa_id", "dbo.Empresas");
            DropIndex("dbo.Empresas", new[] { "Empresa_Empresa_id" });
            DropIndex("dbo.Funcionarios", new[] { "Empresa_Empresa_id" });
            RenameColumn(table: "dbo.Funcionarios", name: "Empresa_Empresa_id", newName: "Empresa_id");
            AlterColumn("dbo.Funcionarios", "Empresa_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Funcionarios", "Empresa_id");
            AddForeignKey("dbo.Funcionarios", "Empresa_id", "dbo.Empresas", "Empresa_id", cascadeDelete: true);
            DropColumn("dbo.Empresas", "Empresa_Empresa_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Empresas", "Empresa_Empresa_id", c => c.Int());
            DropForeignKey("dbo.Funcionarios", "Empresa_id", "dbo.Empresas");
            DropIndex("dbo.Funcionarios", new[] { "Empresa_id" });
            AlterColumn("dbo.Funcionarios", "Empresa_id", c => c.Int());
            RenameColumn(table: "dbo.Funcionarios", name: "Empresa_id", newName: "Empresa_Empresa_id");
            CreateIndex("dbo.Funcionarios", "Empresa_Empresa_id");
            CreateIndex("dbo.Empresas", "Empresa_Empresa_id");
            AddForeignKey("dbo.Funcionarios", "Empresa_Empresa_id", "dbo.Empresas", "Empresa_id");
            AddForeignKey("dbo.Empresas", "Empresa_Empresa_id", "dbo.Empresas", "Empresa_id");
        }
    }
}
