using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Modelo
{
    public class Model
    {
        public bool ValidateUser(string username, string password)
        {
           
            return username == "admin" && password == "123"; 
        }
    }

}
