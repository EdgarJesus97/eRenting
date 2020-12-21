namespace eRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmpresaTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        Empresa_id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 120),
                        Morada = c.String(nullable: false),
                        Nif = c.Int(nullable: false),
                        Cod_postal_cidade = c.Int(nullable: false),
                        Cod_postal_rua = c.Int(nullable: false),
                        Localidade = c.String(nullable: false),
                        Contacto = c.Int(nullable: false),
                        Fax = c.Int(nullable: false),
                        Email = c.String(maxLength: 120),
                    })
                .PrimaryKey(t => t.Empresa_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empresas");
        }
    }
}
