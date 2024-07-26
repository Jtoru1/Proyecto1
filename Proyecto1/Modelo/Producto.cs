using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Modelo
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public string Display => $"{Nombre} - Cantidad Actual: {Cantidad}";
        public Producto(int id, string nombre, string descripcion, string precio, int cantidad)
        {
            var precioConvertido = Utilidades.Utilidades.StrToDoubleConDefault(precio,0.0);
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precioConvertido;
            Cantidad = cantidad;
           


        }

        public Producto() { }
    }
}
