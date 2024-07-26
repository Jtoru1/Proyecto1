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
    public class ControladorProducto
    {
        private List<Producto> productos = Datos2.productos;

        public List<Producto> obtenerProductos()
        {
            return productos;
        }
        public Producto GetProducto(int id)
        {
            return Datos2.ObtenerProductoPorId(id);
        }

        public string VerificarInventarioBajo(Producto producto)
        {
            switch (producto.Cantidad)
            {

                case 0:
                    return " Sin unidades";
                case <=5:
                    return " Unidades bajas ";

                case > 5:
                    return " Unidades normales";
            }
        }
    }
}
