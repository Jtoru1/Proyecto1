using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1.Datos;

namespace Proyecto1.Controlador
{
    
        public class ControladorEditarCliente 
        {
           public ControladorEditarCliente() { }

        public void editarCliente(Cliente cliente)
        {
            Datos2.EditarCliente(cliente);
        }
        }
    
}
