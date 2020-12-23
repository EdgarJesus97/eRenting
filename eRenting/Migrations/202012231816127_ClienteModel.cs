namespace eRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClienteModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Cliente_id = c.Int(nullable: false, identity: true),
                        primeiro_nome = c.String(nullable: false, maxLength: 50),
                        NIF = c.Int(nullable: false),
                        Cod_postal_cidade = c.Int(nullable: false),
                        Cod_postal_rua = c.Int(nullable: false),
                        Localidade = c.String(nullable: false),
                        Contacto = c.Int(nullable: false),
                        Email = c.String(maxLength: 120),
                    })
                .PrimaryKey(t => t.Cliente_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
