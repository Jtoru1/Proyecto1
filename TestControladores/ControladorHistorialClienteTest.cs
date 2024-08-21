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
    public class ControladorHistorialClienteTest
    {
        private ControladorHistorialCliente _controladorHistorialCliente;

        [TestInitialize]
        public void Setup()
        {
            

            // Configura datos de prueba
            Datos2.facturas = new List<Factura>
        {
            new Factura
            {
                IdCliente = "999",
                Ventas = new List<Venta>
                {
                    new Venta { ProductoId = 1, Cantidad = 2 },
                    new Venta { ProductoId = 2, Cantidad = 1 }
                }
            },
            new Factura
            {
                IdCliente = "2",
                Ventas = new List<Venta>
                {
                    new Venta { ProductoId = 1, Cantidad = 1 }
                }
            }
        };

            Datos2.productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Producto1", Descripcion = "Descripción Producto1", Precio = 10.0, Cantidad = 100 },
            new Producto { Id = 2, Nombre = "Producto2", Descripcion = "Descripción Producto2", Precio = 20.0, Cantidad = 200 }
        };

            // Inicializa el controlador antes de cada prueba
            _controladorHistorialCliente = new ControladorHistorialCliente();
        }

        [TestMethod]
        public void ObtenerHistorialVentas_ClienteConVentas_ReturnsCorrectVentas()
        {
            // Arrange
            int idCliente = 999;

            // Act
            var result = _controladorHistorialCliente.ObtenerHistorialVentas(idCliente);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(1, result[0].ProductoId);
            Assert.AreEqual(2, result[0].Cantidad);
            Assert.AreEqual(2, result[1].ProductoId);
            Assert.AreEqual(1, result[1].Cantidad);
        }

        [TestMethod]
        public void ObtenerHistorialVentas_ClienteSinVentas_ReturnsEmptyList()
        {
            // Arrange
            int idCliente = 80; // Cliente que no existe en las facturas

            // Act
            var result = _controladorHistorialCliente.ObtenerHistorialVentas(idCliente);

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void ObtenerProductoPorId_ProductoExiste_ReturnsCorrectProducto()
        {
            // Arrange
            int productoId = 1;

            // Act
            var result = _controladorHistorialCliente.ObtenerProductoPorId(productoId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Producto1", result.Nombre);
            Assert.AreEqual(10.0, result.Precio);
        }

        [TestMethod]
        public void ObtenerProductoPorId_ProductoNoExiste_ReturnsNull()
        {
            // Arrange
            int productoId = 999; // Producto que no existe

            // Act
            var result = _controladorHistorialCliente.ObtenerProductoPorId(productoId);

            // Assert
            Assert.IsNull(result);
        }
    }

}
