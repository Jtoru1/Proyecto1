using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Proyecto1.Modelo.MetodoPago;

namespace Proyecto1.Controlador
{
    public class ControladorArchivo
    {
        public string LoadFile(string filePath)
        {
            var content = File.ReadAllText(filePath);
            return content;
        }
        public List<Cajero> CargarCajeros(string path)
        {
            var result = new List<Cajero>();

            try
            {

                var content = this.LoadFile(path);


                var lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);


                foreach (var line in lines)
                {

                    var parts = line.Split(',');


                    if (parts.Length < 3)
                    {
                        throw new FormatException("La línea del archivo no tiene el formato esperado.");
                    }
                    var cajero = new Cajero(parts[0], parts[1], parts[2]);
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
        public List<Cliente> CargarClientes(string path)
        {
            var result = new List<Cliente>();
            try
            {
                var content = this.LoadFile(path);
                var lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var line in lines)
                {

                    var parts = line.Split(',');


                    if (parts.Length < 6)
                    {
                        throw new FormatException("La línea del archivo no tiene el formato esperado.");
                    }
                    int idcliente;
                    bool canConvert = int.TryParse(parts[0], out idcliente);
                    if (canConvert)
                    {
                        var cliente = new Cliente(idcliente, parts[1], parts[2], parts[3], parts[4], parts[5]);
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
        public List<Producto> CargarProductos(string path)
        {
            var result = new List<Producto>();
            try
            {
                var content = this.LoadFile(path);
                var lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var line in lines)
                {

                    var parts = line.Split(',');


                    if (parts.Length < 5)
                    {
                        throw new FormatException("La línea del archivo no tiene el formato esperado.");
                    }
                    int idproducto;
                    bool canConvert = int.TryParse(parts[0], out idproducto);
                    if (canConvert)
                    {
                        var cantidad = Utilidades.Utilidades.StrToIntConDefault(parts[4], 0);
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

        public static string ObtenerRutaRaizProyecto()
        {
            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.Parent.FullName;
            return projectDirectory;
        }


        public void guardarClientes(List<Cliente> clientes, string path)
        {
            try
            {
                string rutaProyecto = ObtenerRutaRaizProyecto();
                string rutaArchivo = Path.Combine(rutaProyecto, path);
                using (var writer = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
                {

                    // Escribir cada producto
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
        public void guardarProductos(List<Producto> productos, string path)
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
        public void GuardarFacturas(List<Factura> facturas, string path)
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
        public List<Factura> CargarFacturas(string path)
        {
            var result = new List<Factura>();
            try
            {
                var content = this.LoadFile(path);
                var lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var line in lines) 
                {
                    var parts = line.Split(',');

                    if (parts.Length < 11)
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

                        var factura = result.FirstOrDefault(f => f.Id == idFactura);
                        if (factura == null)
                        {
                            factura = new Factura
                            {
                                Id = idFactura,
                                IdCliente = idCliente,
                                Fecha = fecha,
                                MetodoPago = metodoPago,
                                IdVendedor = idVendedor
                            };
                            result.Add(factura);
                        }

                        var venta = new Venta
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
