using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUDEjemplo.Models;
using System.Data.Entity;

namespace CRUDEjemplo.App_Start
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            context.Personas.Add(new Persona
            {
                Nombre = "Erwin Alves",
                Edad = 31,
                Correo = "erwinalvessilva@gmail.com",
                Telefono = "955121117",
                Direccion = "Santo tomás de Aquino 8189, La florida",
                FechaNacimiento = new DateTime(1993, 9, 6),
                Genero = "M",
                Rut = "18.464.662-5"
            });

            base.Seed(context);
        }
    }
}