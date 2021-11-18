using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Models
{
    class Ventas
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public ICollection<Clientes> Clientes { get; set; }
        public IList<DescVentas> DescVentas { get; set; }

    }
}
