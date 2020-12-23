namespace eRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmpresa : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Funcionarios", "Empresa_Empresa_id", "dbo.Empresas");
            DropIndex("dbo.Funcionarios", new[] { "Empresa_Empresa_id" });
            RenameColumn(table: "dbo.Funcionarios", name: "Empresa_Empresa_id", newName: "Empresa_id");
            AlterColumn("dbo.Funcionarios", "Empresa_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Funcionarios", "Empresa_id");
            AddForeignKey("dbo.Funcionarios", "Empresa_id", "dbo.Empresas", "Empresa_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Funcionarios", "Empresa_id", "dbo.Empresas");
            DropIndex("dbo.Funcionarios", new[] { "Empresa_id" });
            AlterColumn("dbo.Funcionarios", "Empresa_id", c => c.Int());
            RenameColumn(table: "dbo.Funcionarios", name: "Empresa_id", newName: "Empresa_Empresa_id");
            CreateIndex("dbo.Funcionarios", "Empresa_Empresa_id");
            AddForeignKey("dbo.Funcionarios", "Empresa_Empresa_id", "dbo.Empresas", "Empresa_id");
        }
    }
}
