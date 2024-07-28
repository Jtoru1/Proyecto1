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
        static Datos2 ()
        {
            CargarDatos();
        }
        private static void CargarDatos()
        {
            cajeros = controladorArchivo.CargarCajeros(nombreArchivo);
            clientes = controladorArchivo.CargarClientes(archivoClientes);
            productos= controladorArchivo.CargarProductos(archivoProductos);
        }
        public static void AgregarCliente(Cliente cliente)
        {
            cliente.Id = IdUsuario();
            clientes.Add(cliente);
            controladorArchivo.guardarClientes(clientes, archivoClientes);

        }
        public static void AgregarProducto(Producto producto)
        {
            producto.Id = IdProducto();
            productos.Add(producto);
            controladorArchivo.guardarProductos(productos, archivoProductos);

        }
        private static int IdUsuario()
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
        private static int IdProducto()
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
        public static void EditarCliente(Cliente cliente)
        {
            var editarCliente = clientes.FirstOrDefault(c => c.Id == cliente.Id);
            if (editarCliente != null)
            {
                editarCliente.Nombre = cliente.Nombre;
                editarCliente.Apellido = cliente.Apellido;
                editarCliente.Direccion = cliente.Direccion;
                editarCliente.Numero = cliente.Numero;
                editarCliente.Correo = cliente.Correo;

            }
            controladorArchivo.guardarClientes(clientes, archivoClientes);
        }
        public static void EditarProducto(Producto producto)
        {
            var editarProducto = productos.FirstOrDefault(c => c.Id == producto.Id);
            if (editarProducto != null)
            {
                editarProducto.Nombre = producto.Nombre;
                editarProducto.Descripcion = producto.Descripcion;
                editarProducto.Precio = producto.Precio;
                editarProducto.Cantidad = producto.Cantidad;

            }
            controladorArchivo.guardarClientes(clientes, archivoClientes);
        }
        public static void ActualizarClientes ()
        {
            controladorArchivo.guardarClientes(clientes,archivoClientes);
        }
        public static void ActualizarProductos()
        {
            controladorArchivo.guardarProductos(productos, archivoProductos);
        }
        public static Cliente ObtenerClientePorId (int id)
        {
            return clientes.FirstOrDefault(cliente => cliente.Id == id);
        }
        public static Producto ObtenerProductoPorId(int id)
        {
            return productos.FirstOrDefault(producto => producto.Id == id);
        }
    }

}
