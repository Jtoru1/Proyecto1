using Moq;
using Proyecto1.Controlador;
using Proyecto1.Datos;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1.Datos;

namespace TestControladores
{
        
    [TestClass]
    public class ControladorClienteTest
    {
        
        private ControladorCliente _controladorCliente;
        private Action _mockActualizarClientes;
        [TestInitialize]
        public void Setup()
        {
            // Inicializa el mock y el controlador antes de cada prueba
            _mockActualizarClientes = () => { /* Acción vacía */ };
              // Configura datos de prueba
                var clientesPrueba = new List<Cliente>
        {
            new Cliente { Id = 1, Nombre = "Cliente1" },
            new Cliente { Id = 2, Nombre = "Cliente2" }
        };

            Datos2.clientes = clientesPrueba;
            _controladorCliente = new ControladorCliente();
            //Datos2.ActualizarClientes= () => { /* Acción vacía */ };
        }

        [TestMethod]
        public void ObtenerClientes_ReturnsListOfClientes()
        {
            // Act
            var result = _controladorCliente.obtenerClientes();

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Cliente1", result.First().Nombre);
        }

        [TestMethod]
        public void GetCliente_ReturnsCorrectCliente()
        {
            // Arrange
            var clienteId = 1;
            var clienteEsperado = new Cliente { Id = clienteId, Nombre = "Cliente1" };

            // Act
            var result = _controladorCliente.getCliente(clienteId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(clienteEsperado.Nombre,result.Nombre);
        }

     
    }
}
