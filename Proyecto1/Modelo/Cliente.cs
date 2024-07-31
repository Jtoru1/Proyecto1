
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Modelo
{
    public class Cliente // Atributos necesarios que debe tener e cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Numero { get; set; }
        public string Correo { get; set; }

        public string Display => $"{Nombre} - {Correo}"; // Método para poder ver el nombre y correo del Cliente en la pantalla 
        public Cliente(int id, string nombre, string apellido, string direccion, string numero, string correo)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Numero = numero;
            Correo = correo;


        }

        public Cliente() { }
    }

}
