using Proyecto1.Datos;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Controlador
{
    public class ControladorVenta
    {
        private List<Cliente> clientes = Datos2.clientes;
        private List<Producto> productos = Datos2.productos;
        private List<Venta> preventa = new List<Venta> ();
            
        public List<Cliente> obtenerClientes()
        {
            return clientes;
        }
        public Cliente getCliente(int id)
        {
            return Datos2.ObtenerClientePorId(id);
        }

        public List<Producto> getProductos()
        {
            return productos;
        }
        public Producto getProducto(int id)
        {
           return Datos2.ObtenerProductoPorId(id);
        }
        private  int IdPreVenta()
        {
            if (preventa.Any())
            {
                return preventa.Max(c => c.Id) + 1;
            }
            else
            {
                return 1; 
            }
        }
        public void  agregarVenta(Venta venta)
        {
            venta.Id= IdPreVenta(); 
            preventa.Add(venta);
        }
        public List<Venta> ObtenerPreventa()
        {
            return preventa;
        }

    }
}
