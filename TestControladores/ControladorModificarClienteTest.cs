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
    public class ControladorModificarClienteTest
    {
        private ControladorModificarCliente _controladorModificarCliente;

        [TestInitialize]
        public void Setup()
        {
            // Inicializa el controlador antes de cada prueba
            _controladorModificarCliente = new ControladorModificarCliente();

            // Inicializa la lista de clientes en Datos2
            Datos2.clientes = new List<Cliente>();
        }

        [TestMethod]
        public void AgregarCliente_NuevoCliente_ClienteAgregadoCorrectamente()
        {
            // Arrange
            var nuevoCliente = new Cliente
            {
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "Calle Falsa 123",
                Numero = "123456789",
                Correo = "juan.perez@example.com"
            };

            // Act
            _controladorModificarCliente.AgregarCliente(nuevoCliente);

            // Assert
            Assert.AreEqual(1, Datos2.clientes.Count); // Verifica que se haya agregado un cliente
            Assert.AreEqual("Juan", Datos2.clientes[0].Nombre);
            Assert.AreEqual("Perez", Datos2.clientes[0].Apellido);
            Assert.AreEqual("Calle Falsa 123", Datos2.clientes[0].Direccion);
            Assert.AreEqual("123456789", Datos2.clientes[0].Numero);
            Assert.AreEqual("juan.perez@example.com", Datos2.clientes[0].Correo);
        }

        [TestMethod]
        public void AgregarCliente_VariosClientes_ClientesAgregadosCorrectamente()
        {
            // Arrange
            var cliente1 = new Cliente
            {
                Nombre = "Ana",
                Apellido = "Gomez",
                Direccion = "Avenida Siempre Viva 456",
                Numero = "987654321",
                Correo = "ana.gomez@example.com"
            };

            var cliente2 = new Cliente
            {
                Nombre = "Luis",
                Apellido = "Martinez",
                Direccion = "Calle Luna 789",
                Numero = "1122334455",
                Correo = "luis.martinez@example.com"
            };

            // Act
            _controladorModificarCliente.AgregarCliente(cliente1);
            _controladorModificarCliente.AgregarCliente(cliente2);

            // Assert
            Assert.AreEqual(2, Datos2.clientes.Count); // Verifica que se hayan agregado dos clientes

            // Verifica los datos del primer cliente
            Assert.AreEqual("Ana", Datos2.clientes[0].Nombre);
            Assert.AreEqual("Gomez", Datos2.clientes[0].Apellido);

            // Verifica los datos del segundo cliente
            Assert.AreEqual("Luis", Datos2.clientes[1].Nombre);
            Assert.AreEqual("Martinez", Datos2.clientes[1].Apellido);
        }
    }

}
