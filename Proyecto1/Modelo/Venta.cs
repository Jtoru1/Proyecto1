using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Modelo
{
    public class Venta //Atributos necesarios que debe tener una venta
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double Total => Cantidad * PrecioUnitario;

    }
}
