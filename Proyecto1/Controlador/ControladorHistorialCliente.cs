using Proyecto1.Datos;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Controlador
{
    public class ControladorHistorialCliente  // Controlador para verificar el historial de compras del cliente 
    {
        private List<Factura> facturas = Datos2.facturas; // Método para obtener las facturas por medio de datos
        public List<Venta> ObtenerHistorialVentas(int idCliente)
        {
            var historialVentas = new List<Venta>();

            // Filtra las facturas por el ID del cliente
            var facturasCliente = facturas.Where(f => f.IdCliente == idCliente.ToString()).ToList();

            // Extrae las ventas de las facturas del cliente
            foreach (var factura in facturasCliente)
            {
                historialVentas.AddRange(factura.Ventas);
            }

            return historialVentas;
        }
        public Producto ObtenerProductoPorId (int productoId) // Método para obtener el producto por medio del ID
        {
            return Datos2.ObtenerProductoPorId(productoId);
        }

    }
}
