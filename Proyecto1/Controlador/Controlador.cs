using Proyecto1.Modelo;
using Proyecto1.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto1.Datos;

namespace Proyecto1.Controlador
{
    public class LoginController
    {
        private string nombreArchivo = "UsuarioCajeros.csv";
        private ControladorArchivo controladorArchivo = new ControladorArchivo();
        private List<Cajero> cajeros = Datos2.cajeros;

        public LoginController() { }
        public bool autenticarUsuario (string username, string password)
        {
            return cajeros.Any(c=>c.Correo==username && c.Contrasena==password);   
            
        }
        public List<Cajero> GetUsers()
        {
            //var filePath = this.GetFile(nombreArchivo);
            var result = this.controladorArchivo.CargarCajeros(nombreArchivo);
            return result;
        }

        public Cajero obtenerCajero(string username)
        {
            Cajero cajeroEncontrado = cajeros.FirstOrDefault(c => c.Correo == username);
            if (cajeroEncontrado == null)
            {
                return null;
            }
            else
            {
                return cajeroEncontrado;
            }

        }

    }
}
