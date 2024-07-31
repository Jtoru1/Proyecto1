using Proyecto1.Datos;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Controlador
{
    public class ControladorReportes // Controlador de los reportes de ventas 
    {
        private List<Factura> facturas=Datos2.facturas; // Lista de facturas obtenida desde la clase Datos
        public List<Factura> ObtenerFacturas () // Método para obtener las facturas 
        {
            return facturas;
        }
        public List<Factura> ObtenerVentasPorFecha(DateTime fecha) // Método para obtener una venta por una fecha determinada 
        {
            return facturas.Where(f => f.Fecha.Date == fecha.Date).ToList();
        }

      
        public List<Factura> ObtenerVentasPorMesYAño(int mes, int año)   // Reporte de ventas por mes y año
        {
            return facturas.Where(f => f.Fecha.Month == mes && f.Fecha.Year == año).ToList();
        }

       
        public List<(string IdVendedor, double TotalVentas)> ObtenerVendedoresConMayoresVentas() // Vendedores con mayores índices de ventas
        {
            return facturas.GroupBy(f => f.IdVendedor)
                           .Select(grp => (IdVendedor: grp.Key, TotalVentas: grp.Sum(f => f.Total)))
                           .OrderByDescending(v => v.TotalVentas)
                           .ToList();
        }

     
        public List<(string IdCliente, double TotalCompras)> ObtenerClientesConMayoresCompras() // Clientes con mayores compras
        {
            return facturas.GroupBy(f => f.IdCliente)
                           .Select(grp => (IdCliente: grp.Key, TotalCompras: grp.Sum(f => f.Total)))
                           .OrderByDescending(c => c.TotalCompras)
                           .ToList();
        }
        public Cliente ObtenerClientePorId (int id)
        {
           return Datos2.ObtenerClientePorId(id);
            
        }
    }

}
