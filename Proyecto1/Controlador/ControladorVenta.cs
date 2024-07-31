using Proyecto1.Datos;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Controlador
{
    public class ControladorVenta  // Controlador de venta 
    {
        private List<Cliente> clientes = Datos2.clientes; // Se obtiene la lista de cliente de la clase Datos
        private List<Producto> productos = Datos2.productos; // Se obitnee la lista productos de la clase Datos
        private List<Venta> preventa = new List<Venta> ();
            
        public List<Cliente> obtenerClientes() // Método para obtener clientes 
        {
            return clientes;
        }
        public Cliente getCliente(int id) // Obtener cliente por ID
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
        private  int IdPreVenta() // Método para obtener un id en la preventa 
        {
            if (preventa.Any()) // Verificar si la lista de preventas contiene algun archivo  
            {
                return preventa.Max(c => c.Id) + 1; // Si hay elementos, se incrementa en 1 el ID 
            }
            else
            {
                return 1; 
            }
        }
        public void  agregarVenta(Venta venta) // Método para agregar una venta 
        {
            venta.Id= IdPreVenta(); 
            preventa.Add(venta);
        }
        public List<Venta> ObtenerPreventa()
        {
            return preventa;
        }

        public void RealizarVenta (Cliente cliente,Cajero cajero,MetodoPago.TipoPago metodoPago) // Método para realizar una venta 
        {
            DateTime fechaActual = DateTime.Now;
            string fechaFormateada = fechaActual.ToString("dd/MM/yyyy");
            Factura factura = new Factura();
            factura.Fecha = fechaActual;
            factura.IdVendedor = cajero.Correo;
            factura.IdCliente = cliente.Id.ToString();
            factura.Ventas = preventa;
            factura.MetodoPago = metodoPago;
            Datos2.AgregarFactura(factura);
        }

    }
}
