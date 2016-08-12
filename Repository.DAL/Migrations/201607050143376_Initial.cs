namespace Repository.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        EstadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estado", t => t.EstadoId, cascadeDelete: true)
                .Index(t => t.EstadoId);
            
            CreateTable(
                "dbo.Estado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        UF = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        CPF = c.String(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Sexo = c.String(nullable: false),
                        Telefone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        CidadeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cidade", t => t.CidadeId, cascadeDelete: true)
                .Index(t => t.CidadeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cliente", "CidadeId", "dbo.Cidade");
            DropForeignKey("dbo.Cidade", "EstadoId", "dbo.Estado");
            DropIndex("dbo.Cliente", new[] { "CidadeId" });
            DropIndex("dbo.Cidade", new[] { "EstadoId" });
            DropTable("dbo.Cliente");
            DropTable("dbo.Estado");
            DropTable("dbo.Cidade");
        }
    }
}
