using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Models
{
    class DescVentas
    {
        public int Id { get; set; }
        public int VentasId { get; set; }
        public Ventas Ventas { get; set; }

        public int ProductosId { get; set; }
        public Productos Productos { get; set; }

        public int Cantidad { get; set; }
    }
}
