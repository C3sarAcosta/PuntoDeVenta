using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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

            base.OnConfiguring(optionsBuilder);

            /*optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Nombre de la base de datos; Itegrated Security=True")
                .EnableSensitiveDataLogging(true);*/
        }

        /*public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        {
            builder
                .AddFilter((category, level) =>
                category == DbLoggerCategory.Database.Command.Name
                && level == LogLevel.Information)
                .AddProvider();
        });*/

        //Propiedad la cual indica a EntityFramework que vamos a tener una tabla para poder comunicarnos
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
    }
}
