using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Models
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Crear la conexion a la base de datos
            /*
             *Host = 127.0.0.1
             *Datebase = Nombre de la base de datos
             *Username = usuario con el que entrar a la base de datos
             *Password = la contraseña de la base de datos
             */
            optionsBuilder.UseNpgsql("Host=localhost; Database=Clase; Username=postgres; password=nada123")
              .EnableSensitiveDataLogging(true);

            /*optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Nombre de la base de datos; Itegrated Security=True")
                .EnableSensitiveDataLogging(true);*/
        }
    }
}
