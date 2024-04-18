namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambiotipoIdentidad : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DClientes", "Identidad", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DClientes", "Identidad", c => c.Int(nullable: false));
        }
    }
}
