namespace CRUDEjemplo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarValidacionesPersona : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Personas", "Nombre", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personas", "Nombre", c => c.String());
        }
    }
}
