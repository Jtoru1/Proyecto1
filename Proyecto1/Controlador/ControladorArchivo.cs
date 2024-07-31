using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Proyecto1.Modelo.MetodoPago;

namespace Proyecto1.Controlador
{
    public class ControladorArchivo // Controlador general del proyecto, gestiona la carga y guardado de archivos
    {
        public string LoadFile(string filePath) //Meotdo para leer el contenido del archivo como texto
        {
            var content = File.ReadAllText(filePath);
            return content;
        }
        public List<Cajero> CargarCajeros(string path) // Metodo para cargar los cajeros desde un archivo CSV
        {
            var result = new List<Cajero>();

            try
            {

                var content = this.LoadFile(path); // Lee el contenido del archivo


                var lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);


                foreach (var line in lines)
                {

                    var parts = line.Split(',');


                    if (parts.Length < 3) // Verificar que la linea tenga el formato esperado 
                    {
                        throw new FormatException("La línea del archivo no tiene el formato esperado.");
                    }
                    var cajero = new Cajero(parts[0], parts[1], parts[2]);  // Crear un nuevo cajero y agregarlo a la lista 
                    result.Add(cajero);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
                MessageBox.Show("Error al cargar el archivo." + ex.Message);
            }

            return result;
        }
        public List<Cliente> CargarClientes(string path) // Método para cargar clientes desde un csv
        {
            var result = new List<Cliente>();
            try
            {
                var content = this.LoadFile(path);// Lee el contenido del archivo
                var lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var line in lines)
                {

                    var parts = line.Split(',');


                    if (parts.Length < 6) // Verificar que la linea tenga el formato esperado 
                    {
                        throw new FormatException("La línea del archivo no tiene el formato esperado.");
                    }
                    int idcliente;  // Convertir el ID cliente a un entero
                    bool canConvert = int.TryParse(parts[0], out idcliente);
                    if (canConvert)
                    {
                        var cliente = new Cliente(idcliente, parts[1], parts[2], parts[3], parts[4], parts[5]); // Crear un nuevo cliente y agregarlo a la lista de resultados 
                        result.Add(cliente);
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
                MessageBox.Show("Error al cargar el archivo." + ex.Message);
            }
            return result;
        }
        public List<Producto> CargarProductos(string path) // Método de carga de productos desde un archivo csv
        {
            var result = new List<Producto>();
            try
            {
                var content = this.LoadFile(path); // Leer el contenido del archivo 
                var lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var line in lines)
                {

                    var parts = line.Split(',');


                    if (parts.Length < 5) // Verificar que la linea tenga el formato esperado 
                    {
                        throw new FormatException("La línea del archivo no tiene el formato esperado.");
                    }
                    int idproducto; // Convertir el ID a un entero 
                    bool canConvert = int.TryParse(parts[0], out idproducto);
                    if (canConvert)
                    {
                        var cantidad = Utilidades.Utilidades.StrToIntConDefault(parts[4], 0); // Convertir la cantidad utilizando un método utilitario, en la clase de Utilidades 
                        var producto = new Producto(idproducto, parts[1], parts[2], parts[3], cantidad);
                        result.Add(producto);
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
                MessageBox.Show("Error al cargar el archivo." + ex.Message);
            }
            return result;
        }

        public static string ObtenerRutaRaizProyecto() // Método para obtener la raiz del proyecto 
        {
            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.Parent.FullName;
            return projectDirectory;
        }


        public void guardarClientes(List<Cliente> clientes, string path) // Método para guardar la lista de clientes en un archivo csv
        {
            try
            {
                string rutaProyecto = ObtenerRutaRaizProyecto();
                string rutaArchivo = Path.Combine(rutaProyecto, path);
                using (var writer = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
                {

                    // Escribir cada cliente en el archivo
                    foreach (var cliente in clientes)
                    {
                        writer.WriteLine($"{cliente.Id},{cliente.Nombre},{cliente.Apellido},{cliente.Direccion},{cliente.Numero},{cliente.Correo}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
                MessageBox.Show("Error al guardar el archivo." + ex.Message);
            }

        }
        public void guardarProductos(List<Producto> productos, string path) // Método de guardado de productos en un archivo csv
        {
            try
            {
                string rutaProyecto = ObtenerRutaRaizProyecto();
                string rutaArchivo = Path.Combine(rutaProyecto, path);
                using (var writer = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
                {

                    // Escribir cada producto
                    foreach (var producto in productos)
                    {
                        writer.WriteLine($"{producto.Id},{producto.Nombre},{producto.Descripcion},{producto.Precio},{producto.Cantidad}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
                MessageBox.Show("Error al guardar el archivo." + ex.Message);
            }

        }
        public void GuardarFacturas(List<Factura> facturas, string path) // Método para guardar la lista de facturas en un archivo csv
        {
            try
            {
                string rutaProyecto = ObtenerRutaRaizProyecto();
                string rutaArchivo = Path.Combine(rutaProyecto, path);
                using (var writer = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
                {
                   
                    foreach (var factura in facturas)
                    {
                        foreach (var venta in factura.Ventas)
                        {
                            writer.WriteLine($"{factura.Id},{factura.IdCliente},{factura.Fecha},{venta.Id},{venta.ProductoId},{venta.Cantidad},{venta.PrecioUnitario},{venta.Total},{factura.MetodoPago},{factura.IdVendedor},{factura.Total}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }
        }
        public List<Factura> CargarFacturas(string path) // Método para cargar facturas en el archivo csv
        {
            var result = new List<Factura>();
            try
            {
                var content = this.LoadFile(path); // Lee el contenido del archivo 
                var lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var line in lines) 
                {
                    var parts = line.Split(',');

                    if (parts.Length < 11) // Verificar que la linea tenga el formato esperado 
                    {
                        throw new FormatException("La línea del archivo no tiene el formato esperado.");
                    }

                    int idFactura;
                    if (int.TryParse(parts[0], out idFactura))
                    {
                        string idCliente = parts[1];
                        DateTime fecha = DateTime.Parse(parts[2]);
                        int idVenta = int.Parse(parts[3]);
                        int productoId = int.Parse(parts[4]);
                        int cantidad = int.Parse(parts[5]);
                        double precioUnitario = double.Parse(parts[6]);
                        double totalVenta = double.Parse(parts[7]);
                        TipoPago metodoPago = (TipoPago)Enum.Parse(typeof(TipoPago), parts[8]);
                        string idVendedor = parts[9];
                        double totalFactura = double.Parse(parts[10]);

                        var factura = result.FirstOrDefault(f => f.Id == idFactura); // Verificar si la factura ya existe en la lista
                        if (factura == null)
                        {
                            factura = new Factura // Si la factura no existe, crea una nueva y la agrega a la lista
                            {
                                Id = idFactura,
                                IdCliente = idCliente,
                                Fecha = fecha,
                                MetodoPago = metodoPago,
                                IdVendedor = idVendedor
                            };
                            result.Add(factura);
                        }

                        var venta = new Venta  // Crear  una nueva venta y la agrega a la factura 
                        {
                            Id = idVenta,
                            ProductoId = productoId,
                            Cantidad = cantidad,
                            PrecioUnitario = precioUnitario
                        };
                        factura.Ventas.Add(venta);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
                MessageBox.Show("Error al cargar el archivo: " + ex.Message);
            }

            return result;
        }
    }
}
