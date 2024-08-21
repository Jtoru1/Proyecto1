using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1.Controlador;
using Proyecto1.Modelo;
using Proyecto1.Datos;
using Moq;
namespace TestControladores
{
    public class ControladorArchivoStub : ControladorArchivo
    {
        public override List<Cajero> CargarCajeros(string nombreArchivo)
        {
            return new List<Cajero>
        {
            new Cajero { Correo = "cajero1@example.com", Contrasena = "password1" },
            new Cajero { Correo = "cajero2@example.com", Contrasena = "password2" }
        };
        }
    }
    [TestClass]
    public class ControladorTest
    {
        private LoginController _loginController;
        private Mock<ControladorArchivo> _mockControladorArchivo;
        [TestInitialize]
        public void Setup()
        {
            // Inicializa la clase LoginController y la lista de cajeros
            //_loginController = new LoginController();

            _mockControladorArchivo = new Mock<ControladorArchivo>();
            // Prepara una lista de cajeros de prueba

            Datos2.cajeros = new List<Cajero>
            {
                new Cajero { Nombre= "Allan", Correo = "test1@example.com", Contrasena = "password1" },
                new Cajero { Nombre="Josue" , Correo = "test2@example.com", Contrasena = "password2" }
            };

            _loginController = new LoginController
            {
                controladorArchivo = new ControladorArchivoStub()
            };
        }
      
     
        [TestMethod]
        public void AutenticarUsuario_InvalidCredentials_ReturnsFalse()
        {
            // Act
            bool result = _loginController.autenticarUsuario("test1@example.com", "123");

            // Assert
            Assert.AreEqual(result,false);
        }
        [TestMethod]
        public void AutenticarUsuario_ValidCredentials_ReturnsTrue()
        {
            // Act
            bool result = _loginController.autenticarUsuario("test1@example.com", "password1");

            // Assert
            Assert.AreEqual(result,true);
        }
        [TestMethod]
        public void ObtenerCajero_ValidUsername_ReturnsCajero()
        {
            // Act
            Cajero result = _loginController.obtenerCajero("test1@example.com");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Correo, "test1@example.com");
        }
        [TestMethod]
        public void ObtenerCajero_InvalidUsername_ReturnsNull()
        {
            // Act
            Cajero result = _loginController.obtenerCajero("nonexistent@example.com");

            // Assert
            Assert.IsNull(result);
        }
        [TestMethod]
        public void GetUsers_ReturnsListOfCajeros()
        {
            // Arrange
            var expectedCajeros = new List<Cajero>
            {
                 new Cajero { Nombre= "Allan", Correo = "test1@example.com", Contrasena = "password1" },
                new Cajero { Nombre="Josue" , Correo = "test2@example.com", Contrasena = "password2" }
            };
            var cajerosMockData = new List<Cajero>
            {
                 new Cajero { Nombre= "Allan", Correo = "test1@example.com", Contrasena = "password1" },
                new Cajero { Nombre="Josue" , Correo = "test2@example.com", Contrasena = "password2" }
            };

            // Act
            var result = _loginController.GetUsers();

            // Assert
            
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("cajero1@example.com", result[0].Correo);
        }
        [TestMethod]
        public void GetCajeroActual_ReturnsCorrectCajero()
        {
            // Arrange
            var cajero = new Cajero { Correo = "test@example.com", Contrasena = "password" };
            _loginController.setCajeroActual(cajero);

            // Act
            var result = _loginController.getCajeroActual();

            // Assert
            Assert.AreEqual(cajero, result);
        }
    }
}
