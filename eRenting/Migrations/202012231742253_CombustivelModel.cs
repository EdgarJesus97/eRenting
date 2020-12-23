namespace eRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CombustivelModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Combustiveis",
                c => new
                    {
                        Cumbustivel_id = c.Int(nullable: false, identity: true),
                        tipo_combustivel = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Cumbustivel_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Combustiveis");
        }
    }
}
