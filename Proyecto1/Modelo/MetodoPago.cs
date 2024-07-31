using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Modelo
{
    public class MetodoPago //Atributos necesarios del método de pago
    {
        public enum TipoPago
        {
            Efectivo,
            Tarjeta,
            Transferencia
        }
    }
}
