using Proyecto1.Datos;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Controlador
{
    public class ControladorModificarProducto // Controlador para modificar el producto 
    {
        public void AgregarProducto(Producto producto)
        {
            Datos2.AgregarProducto(producto);
        }
    }
}
