using Proyecto1.Datos;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Controlador
{
    public class ControladorProducto // Controlador producto 
    {
        private List<Producto> productos = Datos2.productos; //Lista obtenida desde la clase Datos 

        public List<Producto> obtenerProductos() 
        {
            return productos;
        }
        public Producto GetProducto(int id) // Método para obtener los productos
        {
            return Datos2.ObtenerProductoPorId(id);
        }

        public string VerificarInventarioBajo(Producto producto) // Método para verificar las unidades que hay en el inventario
        {
            switch (producto.Cantidad)
            {

                case 0:
                    return " Sin unidades";  // Si hay 0, el producto se encuentra sin unidades 
                case <=5:
                    return " Unidades bajas "; // Si las unidades menor o igual a 5 unidades imprime el mensaje

                case > 5:
                    return " Unidades normales"; // Si hay más de 5 unidades imprime el mensaje
            }
        }
        public void ActualizarListaProducto() // Actualiza la cantidad en la lista de productos 
        {
            Datos2.ActualizarProductos();
        }
        public void EliminarProducto(int productoId)
        {
            var producto = productos.FirstOrDefault(p => p.Id == productoId);
            if (producto != null)
            {
                productos.Remove(producto);
            }
        }
    }
}
