namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioClienteNombresYapellidos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DClientes", "Nombres", c => c.String());
            AddColumn("dbo.DClientes", "Apellidos", c => c.String());
            DropColumn("dbo.DClientes", "PrimerNombre");
            DropColumn("dbo.DClientes", "SegundoNombre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DClientes", "SegundoNombre", c => c.String());
            AddColumn("dbo.DClientes", "PrimerNombre", c => c.String());
            DropColumn("dbo.DClientes", "Apellidos");
            DropColumn("dbo.DClientes", "Nombres");
        }
    }
}
