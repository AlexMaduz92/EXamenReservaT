namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DañoPorApagonCambioDeDatos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DReservas", "cliente_ClienteId", "dbo.DClientes");
            DropIndex("dbo.DReservas", new[] { "cliente_ClienteId" });
            AddColumn("dbo.DReservas", "ClienteId", c => c.Int());
            DropColumn("dbo.DReservas", "CienteId");
            DropColumn("dbo.DReservas", "cliente_ClienteId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DReservas", "cliente_ClienteId", c => c.Int());
            AddColumn("dbo.DReservas", "CienteId", c => c.Int(nullable: false));
            DropColumn("dbo.DReservas", "ClienteId");
            CreateIndex("dbo.DReservas", "cliente_ClienteId");
            AddForeignKey("dbo.DReservas", "cliente_ClienteId", "dbo.DClientes", "ClienteId");
        }
    }
}
