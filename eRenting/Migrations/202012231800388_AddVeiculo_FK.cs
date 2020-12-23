namespace eRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVeiculo_FK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Veiculos", "Combustivel_id", c => c.Int(nullable: false));
            AddColumn("dbo.Veiculos", "CategoriaVeiculo_id", c => c.Int(nullable: false));
            AddColumn("dbo.Veiculos", "Status_id", c => c.Int(nullable: false));
            AddColumn("dbo.Veiculos", "Empresa_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Veiculos", "Combustivel_id");
            CreateIndex("dbo.Veiculos", "CategoriaVeiculo_id");
            CreateIndex("dbo.Veiculos", "Status_id");
            CreateIndex("dbo.Veiculos", "Empresa_id");
            AddForeignKey("dbo.Veiculos", "CategoriaVeiculo_id", "dbo.CategoriaVeiculos", "Categoria_id", cascadeDelete: true);
            AddForeignKey("dbo.Veiculos", "Combustivel_id", "dbo.Combustiveis", "Cumbustivel_id", cascadeDelete: true);
            AddForeignKey("dbo.Veiculos", "Empresa_id", "dbo.Empresas", "Empresa_id", cascadeDelete: true);
            AddForeignKey("dbo.Veiculos", "Status_id", "dbo.Status", "Estado_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Veiculos", "Status_id", "dbo.Status");
            DropForeignKey("dbo.Veiculos", "Empresa_id", "dbo.Empresas");
            DropForeignKey("dbo.Veiculos", "Combustivel_id", "dbo.Combustiveis");
            DropForeignKey("dbo.Veiculos", "CategoriaVeiculo_id", "dbo.CategoriaVeiculos");
            DropIndex("dbo.Veiculos", new[] { "Empresa_id" });
            DropIndex("dbo.Veiculos", new[] { "Status_id" });
            DropIndex("dbo.Veiculos", new[] { "CategoriaVeiculo_id" });
            DropIndex("dbo.Veiculos", new[] { "Combustivel_id" });
            DropColumn("dbo.Veiculos", "Empresa_id");
            DropColumn("dbo.Veiculos", "Status_id");
            DropColumn("dbo.Veiculos", "CategoriaVeiculo_id");
            DropColumn("dbo.Veiculos", "Combustivel_id");
        }
    }
}
