using Proyecto1.Datos;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Controlador
{
    public class ControladorEditarProducto // Controlador para editar el producto 
    {
        public ControladorEditarProducto() { }

        public void editarProducto(Producto producto) // método para editar el producto desde la lista de datos
        {
            Datos2.EditarProducto(producto);
        }
    }
}
