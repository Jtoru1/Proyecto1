﻿using Proyecto1.Datos;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Controlador
{
    internal class ControladorModificarCliente
    {
        public void AgregarCliente (Cliente cliente)
        {
            Datos2.AgregarCliente(cliente);
        }
    }
}