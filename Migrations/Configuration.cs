namespace CRUDEjemplo.Migrations
{
    using CRUDEjemplo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CRUDEjemplo.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CRUDEjemplo.Models.AppDbContext context)
        {
            // Evitar duplicados
            if (!context.Personas.Any(p => p.Rut == "18.464.662-5"))
            {
                context.Personas.AddOrUpdate(
                    p => p.Rut, // propiedad para identificar duplicados
                    new Persona
                    {
                        Nombre = "Erwin Alves",
                        Edad = 31,
                        Correo = "erwinalvessilva@gmail.com",
                        Telefono = "955121117",
                        Direccion = "Santo tomás de Aquino 8189, La florida",
                        FechaNacimiento = new DateTime(1993, 9, 6),
                        Genero = "M",
                        Rut = "18.464.662-5"
                    }
                );
            }

            base.Seed(context);
        }
    }
}
