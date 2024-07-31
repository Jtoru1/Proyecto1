using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Modelo
{
    public class Cajero // Atributos necesarios que debe tener el cajero
    {
     
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }

        public Cajero(string nombre, string correo, string contrasena)
        {
            
            Nombre = nombre;
            Correo = correo;
            Contrasena = contrasena;
        }

        public Cajero() { } 
    }
}
