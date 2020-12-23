namespace eRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoriaModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoriaVeiculos",
                c => new
                    {
                        Categoria_id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Categoria_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CategoriaVeiculos");
        }
    }
}
