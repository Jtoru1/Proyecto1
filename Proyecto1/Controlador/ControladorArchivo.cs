using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                   bool canConvert= int.TryParse(parts[0], out idcliente);
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
        

        public void guardarClientes (List<Cliente> clientes, string path)
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
    }
}
