namespace Locadora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class main : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Modelo = c.String(),
                        Cor = c.String(),
                        Chassi = c.String(),
                        Placa = c.String(),
                        Categoria_Id = c.Int(),
                        Marca_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.Categoria_Id)
                .ForeignKey("dbo.Marcas", t => t.Marca_Id)
                .Index(t => t.Categoria_Id)
                .Index(t => t.Marca_Id);
            
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        ValorDia = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Sigla = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        Cnh = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Retirada = c.DateTime(nullable: false),
                        Devolucao = c.DateTime(nullable: false),
                        Carro_Id = c.Int(),
                        Cliente_Id = c.Int(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carroes", t => t.Carro_Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Carro_Id)
                .Index(t => t.Cliente_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Cpf = c.String(nullable: false),
                        Cnh = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        ConfirmarSenha = c.String(),
                        Perfil = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locacaos", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Locacaos", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.Locacaos", "Carro_Id", "dbo.Carroes");
            DropForeignKey("dbo.Carroes", "Marca_Id", "dbo.Marcas");
            DropForeignKey("dbo.Carroes", "Categoria_Id", "dbo.Categorias");
            DropIndex("dbo.Locacaos", new[] { "Usuario_Id" });
            DropIndex("dbo.Locacaos", new[] { "Cliente_Id" });
            DropIndex("dbo.Locacaos", new[] { "Carro_Id" });
            DropIndex("dbo.Carroes", new[] { "Marca_Id" });
            DropIndex("dbo.Carroes", new[] { "Categoria_Id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Locacaos");
            DropTable("dbo.Clientes");
            DropTable("dbo.Marcas");
            DropTable("dbo.Categorias");
            DropTable("dbo.Carroes");
        }
    }
}
