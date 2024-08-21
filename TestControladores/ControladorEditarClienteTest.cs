using Proyecto1.Controlador;
using Proyecto1.Datos;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestControladores
{
    [TestClass]
    public class ControladorEditarClienteTest
    {
        private ControladorEditarCliente _controladorEditarCliente;

        [TestInitialize]
        public void Setup()
        {
            // Inicializa Datos2 con un estado conocido
            Datos2.clientes = new List<Cliente>
        {
            new Cliente { Id = 1, Nombre = "ClienteOriginal" },
            new Cliente { Id = 2, Nombre = "ClienteParaNoCambiar" }
        };

            _controladorEditarCliente = new ControladorEditarCliente();
        }

        [TestMethod]
        public void EditarCliente_CorrectamenteActualizaClienteEnDatos2()
        {
            // Arrange
            var clienteAEditar = new Cliente { Id = 1, Nombre = "ClienteEditado" };

            // Act
            _controladorEditarCliente.editarCliente(clienteAEditar);

            // Assert
            var clienteEditado = Datos2.ObtenerClientePorId(clienteAEditar.Id);
            Assert.IsNotNull(clienteEditado);
            Assert.AreEqual("ClienteEditado", clienteEditado.Nombre);
        }

        [TestMethod]
        public void EditarCliente_NoModificaClienteNoExistente()
        {
            // Arrange
            var clienteNoExistente = new Cliente { Id = 999, Nombre = "ClienteNoExistente" };

            // Act
            _controladorEditarCliente.editarCliente(clienteNoExistente);

            // Assert
            var clienteOriginal = Datos2.ObtenerClientePorId(1); // Obtener el cliente original que debería mantenerse igual
            Assert.IsNotNull(clienteOriginal);
            Assert.AreEqual("ClienteOriginal", clienteOriginal.Nombre);
        }
    }

}
