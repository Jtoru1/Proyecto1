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
    public class LoginController  // Controlador de inicio de sesión 
    {
        private string nombreArchivo = "UsuarioCajeros.csv"; // Archivo csv que contiene la información de los cajeros
        private ControladorArchivo controladorArchivo = new ControladorArchivo();
        private List<Cajero> cajeros = Datos2.cajeros;
        private Cajero cajeroActual = null;
        public LoginController() { }
        public bool autenticarUsuario (string username, string password) // Método para verificar datos del usuario
        {
            return cajeros.Any(c=>c.Correo==username && c.Contrasena==password);   
            
        }
        public List<Cajero> GetUsers() // Se obtiene la lista de cajeros desde el archivo csv
        {
           
            var result = this.controladorArchivo.CargarCajeros(nombreArchivo);
            return result;
        }
        public void setCajeroActual (Cajero cajeroActual)
        {
            this.cajeroActual = cajeroActual;
        }
        public Cajero getCajeroActual()
        {
            return this.cajeroActual;
        }

        public Cajero obtenerCajero(string username)
        {
            Cajero cajeroEncontrado = cajeros.FirstOrDefault(c => c.Correo == username); // Busca el nombre del cajero para verificar si coincide con usuario, sino se encuentra, retorna a Null, sino retorna al cajero encontrado
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
