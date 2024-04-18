namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DReserva : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.DReservas", "ClienteId");
            AddForeignKey("dbo.DReservas", "ClienteId", "dbo.DClientes", "ClienteId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DReservas", "ClienteId", "dbo.DClientes");
            DropIndex("dbo.DReservas", new[] { "ClienteId" });
        }
    }
}
