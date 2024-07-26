using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Proyecto1.Modelo.MetodoPago;

namespace Proyecto1.Modelo
{
    public class Factura
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public List<Venta> Ventas { get; set; }
        public TipoPago MetodoPago { get; set; }
        public double Total => Ventas.Sum(v => v.Total);

        public Factura()
        {
            Ventas = new List<Venta>();
        }
    }
}
