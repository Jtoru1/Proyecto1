using Proyecto1.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1.Modelo;

namespace Proyecto1.Controlador
{
    public class ControladorCliente // Controlador del cliente 
    {
        private List<Cliente> clientes = Datos2.clientes; // Lista obtenida desde la clase Datos

        public List<Cliente> obtenerClientes()
        {
            return clientes;
        }
        public Cliente getCliente(int id) // Obtener cliente por Id
        {
            return Datos2.ObtenerClientePorId(id);
        }

        public  void ActualizarListaCliente () // Método para para actualizar la lista de clientes desde datos
        {
           Datos2.ActualizarClientes();
        }
        public void EliminarCliente(int clienteId)
        {
            var cliente = clientes.FirstOrDefault(p => p.Id == clienteId);
            if (cliente != null)
            {
                clientes.Remove(cliente);
                Datos2.ActualizarClientes();
            }
        }
    }
}
