namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionTablas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DClientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        PrimerNombre = c.String(),
                        SegundoNombre = c.String(),
                        Identidad = c.Int(nullable: false),
                        Correo = c.String(),
                        Celular = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.DReservas",
                c => new
                    {
                        ReservaId = c.Int(nullable: false, identity: true),
                        FechaReserva = c.DateTime(nullable: false),
                        TeatroId = c.Int(nullable: false),
                        CienteId = c.Int(nullable: false),
                        AsientoN = c.Int(nullable: false),
                        cliente_ClienteId = c.Int(),
                    })
                .PrimaryKey(t => t.ReservaId)
                .ForeignKey("dbo.DClientes", t => t.cliente_ClienteId)
                .ForeignKey("dbo.DTeatroes", t => t.TeatroId, cascadeDelete: true)
                .Index(t => t.TeatroId)
                .Index(t => t.cliente_ClienteId);
            
            CreateTable(
                "dbo.DTeatroes",
                c => new
                    {
                        TeatroId = c.Int(nullable: false, identity: true),
                        NombreTeatro = c.String(),
                        NumeroAsiento = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeatroId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DReservas", "TeatroId", "dbo.DTeatroes");
            DropForeignKey("dbo.DReservas", "cliente_ClienteId", "dbo.DClientes");
            DropIndex("dbo.DReservas", new[] { "cliente_ClienteId" });
            DropIndex("dbo.DReservas", new[] { "TeatroId" });
            DropTable("dbo.DTeatroes");
            DropTable("dbo.DReservas");
            DropTable("dbo.DClientes");
        }
    }
}
