using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Modelo
{
    public class Mes
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }

        public Mes(int numero, string nombre)
        {
            Numero = numero;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
