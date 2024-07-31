using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Utilidades
{
    public  static class Utilidades //Utilidades necesarias para poder convertir los valores
    {
        public static int StrToIntConDefault(string s, int @default)
        {
            int number;
            if (int.TryParse(s, out number))
                return number;
            return @default;
        }
        public static double StrToDoubleConDefault(string s, double @default)
        {
            double number;
            if (double.TryParse(s, out number))
                return number;
            return @default;
        }
    }
}
