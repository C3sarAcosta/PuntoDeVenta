using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Models
{
    class Productos
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
        //Categoria Relacion uno a muchos
        public IList<DescVentas> DescVentas { get; set; }
    }
}
