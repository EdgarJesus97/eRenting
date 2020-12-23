namespace eRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmpresasCollection2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empresas", "Empresa_Empresa_id", c => c.Int());
            CreateIndex("dbo.Empresas", "Empresa_Empresa_id");
            AddForeignKey("dbo.Empresas", "Empresa_Empresa_id", "dbo.Empresas", "Empresa_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empresas", "Empresa_Empresa_id", "dbo.Empresas");
            DropIndex("dbo.Empresas", new[] { "Empresa_Empresa_id" });
            DropColumn("dbo.Empresas", "Empresa_Empresa_id");
        }
    }
}
