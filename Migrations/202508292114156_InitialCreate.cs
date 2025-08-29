namespace CRUDEjemplo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Edad = c.Int(nullable: false),
                        Correo = c.String(),
                        Telefono = c.String(),
                        Direccion = c.String(),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Genero = c.String(),
                        Rut = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personas");
        }
    }
}
