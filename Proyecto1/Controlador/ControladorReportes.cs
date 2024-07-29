using Proyecto1.Datos;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Controlador
{
    public class ControladorReportes
    {
        private List<Factura> facturas=Datos2.facturas;
        public List<Factura> ObtenerFacturas ()
        {
            return facturas;
        }
    }

}
