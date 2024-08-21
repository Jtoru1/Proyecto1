using Proyecto1.Controlador;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto1.Datos
{

    public static class Datos2
    {
        private static string nombreArchivo = "UsuarioCajeros.csv";
        private static ControladorArchivo controladorArchivo = new ControladorArchivo();
        public static List<Cajero> cajeros = new List<Cajero>();
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Producto> productos = new List<Producto>();
        public static List<Factura> facturas = new List<Factura>();
        private static string archivoClientes = "clientes.csv";
        private static string archivoProductos = "productos.csv";
        private static string archivoFacturas = "ventas.csv";
        static Datos2 ()
        {
            CargarDatos();
        }
        private static void CargarDatos() // Método de cargar de datos de cajero, clientes, productos y facturas
        {
            cajeros = controladorArchivo.CargarCajeros(nombreArchivo);
            clientes = controladorArchivo.CargarClientes(archivoClientes);
            productos= controladorArchivo.CargarProductos(archivoProductos);
            facturas=controladorArchivo.CargarFacturas(archivoFacturas);
        }
        public static void AgregarCliente(Cliente cliente) // método para poder agregar al cliente 
        {
            cliente.Id = IdUsuario();
            clientes.Add(cliente);
            controladorArchivo.guardarClientes(clientes, archivoClientes);

        }
        public static void AgregarProducto(Producto producto) // Método para poder agregar el producto 
        {
            producto.Id = IdProducto();
            productos.Add(producto);
            controladorArchivo.guardarProductos(productos, archivoProductos);

        }
        private static int IdUsuario() // Método agregar un id al usuario
        {
            if (clientes.Any())
            {
                return clientes.Max(c => c.Id) + 1;
            }
            else
            {
                return 1; 
            }
        }
        private static int IdProducto() // Método para agregar un id al producto
        {
            if (productos.Any())
            {
                return productos.Max(c => c.Id) + 1;
            }
            else
            {
                return 1; 
            }
        }
        private static int IdFactura() // Método para agregar un ID a la factura
        {
            if (facturas.Any())
            {
                return facturas.Max(c => c.Id) + 1;
            }
            else
            {
                return 1;
            }
        }

        public static void EditarCliente(Cliente cliente) // Método para poder editar los datos del cliente 
        {
            var editarCliente = clientes.FirstOrDefault(c => c.Id == cliente.Id); // Se verificar que tenga un ID para poder editar al cliente
            if (editarCliente != null) 
            {
                editarCliente.Nombre = cliente.Nombre;
                editarCliente.Apellido = cliente.Apellido;
                editarCliente.Direccion = cliente.Direccion;
                editarCliente.Numero = cliente.Numero;
                editarCliente.Correo = cliente.Correo;

            }
            controladorArchivo.guardarClientes(clientes, archivoClientes); // Se guarda el cliente editado 
        }
        public static void EditarProducto(Producto producto) // Método para poder editar el producto 
        {
            var editarProducto = productos.FirstOrDefault(c => c.Id == producto.Id);// Se verificar que tenga un ID para poder editar el producto
            if (editarProducto != null)
            {
                editarProducto.Nombre = producto.Nombre;
                editarProducto.Descripcion = producto.Descripcion;
                editarProducto.Precio = producto.Precio;
                editarProducto.Cantidad = producto.Cantidad;

            }
            controladorArchivo.guardarProductos(productos, archivoProductos); // Se guarda el producto editado 
        }
        public static void ActualizarClientes () // Método para guardar los clientes actualizados 
        {
            controladorArchivo.guardarClientes(clientes,archivoClientes);
        }
        public static void ActualizarProductos() // Método para guaradar los productos actualizados
        {
            controladorArchivo.guardarProductos(productos, archivoProductos);
        }
        public static Cliente ObtenerClientePorId (int id) // Método para obtener el cliente por ID
        {
            return clientes.FirstOrDefault(cliente => cliente.Id == id);
        }
        public static Producto ObtenerProductoPorId(int id) // Método para obtener el producto por ID
        {
            return productos.FirstOrDefault(producto => producto.Id == id);
        }
        public static void AgregarFactura(Factura factura) // Método para agregar una factura 
        {
            factura.Id = IdFactura();
            facturas.Add(factura);
            ActualizarInventarioProductos(factura.Ventas);
            controladorArchivo.GuardarFacturas(facturas,archivoFacturas);
        }
        private static void ActualizarInventarioProductos(List<Venta> ventas) // Método para actualizar el inventario de los productos 
        {
            foreach (var venta in ventas)
            {
                var producto = productos.First(p => p.Id == venta.ProductoId);
                if(producto.Cantidad >= venta.Cantidad) // Si la cantidad es mayor o igual a la cantidad vendida 
                {
                    producto.Cantidad -= venta.Cantidad; // Reduce la cantidad que hay en inventario en ese momento por la cantidad vendida
                }
                else
                {
                    producto.Cantidad = 0; // Si la cantidad es menor a la cantidad vendida, se ajusta a 0
                }
              
            }
            controladorArchivo.guardarProductos(productos,archivoProductos);

        }
    }

}
