using Proyecto1.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1.Modelo;

namespace Proyecto1.Controlador
{
    public class ControladorCliente
    {
        private List<Cliente> clientes = Datos2.clientes;

        public List<Cliente> obtenerClientes()
        {
            return clientes;
        }
        public Cliente getCliente(int id)
        {
            return Datos2.ObtenerClientePorId(id);
        }


    }
}
