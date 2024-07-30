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
        public List<Factura> ObtenerVentasPorFecha(DateTime fecha)
        {
            return facturas.Where(f => f.Fecha.Date == fecha.Date).ToList();
        }

        // Reporte de ventas por mes y año
        public List<Factura> ObtenerVentasPorMesYAño(int mes, int año)
        {
            return facturas.Where(f => f.Fecha.Month == mes && f.Fecha.Year == año).ToList();
        }

        // Vendedores con mayores índices de ventas
        public List<(string IdVendedor, double TotalVentas)> ObtenerVendedoresConMayoresVentas()
        {
            return facturas.GroupBy(f => f.IdVendedor)
                           .Select(grp => (IdVendedor: grp.Key, TotalVentas: grp.Sum(f => f.Total)))
                           .OrderByDescending(v => v.TotalVentas)
                           .ToList();
        }

        // Clientes con mayores compras
        public List<(string IdCliente, double TotalCompras)> ObtenerClientesConMayoresCompras()
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
