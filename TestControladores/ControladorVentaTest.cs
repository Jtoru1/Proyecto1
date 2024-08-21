using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestControladores
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Proyecto1.Controlador;
    using Proyecto1.Datos;
    using Proyecto1.Modelo;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace TuProyecto.Tests
    {
        [TestClass]
        public class ControladorVentaTests
        {
            private ControladorVenta _controladorVenta;
            private Cliente _cliente;
            private Cajero _cajero;

            [TestInitialize]
            public void Setup()
            {
                // Configuración inicial antes de cada prueba
               

                // Inicializar cliente y cajero de prueba
                _cliente = new Cliente { Id = 1, Nombre = "Joel" };
                _cajero = new Cajero { Correo = "cajero@ejemplo.com" };

                // Mock de la lista de clientes y productos
                Datos2.clientes = new List<Cliente> { _cliente };
                Datos2.facturas = new List<Factura> {
                new Factura {IdVendedor=_cajero.Correo,IdCliente=_cliente.Id.ToString(),Ventas=new List<Venta>{
                new Venta { ProductoId = 2, Cantidad = 1, PrecioUnitario = 200 },new Venta { ProductoId = 1, Cantidad = 2, PrecioUnitario = 100 }}}
                };
                Datos2.productos = new List<Producto>
            {
                new Producto { Id = 1, Nombre = "Producto A", Cantidad = 10, Precio = 100 },
                new Producto { Id = 2, Nombre = "Producto B", Cantidad = 5, Precio = 200 }
            };

                // Mock de las ventas previas
                _controladorVenta = new ControladorVenta();
                _controladorVenta.agregarVenta(new Venta { ProductoId = 1, Cantidad = 2, PrecioUnitario = 100 });
                _controladorVenta.agregarVenta(new Venta { ProductoId = 2, Cantidad = 1, PrecioUnitario = 200 });

            }

            [TestMethod]
            public void ObtenerClientes_RetornaClientesCorrectamente()
            {
                // Act
                var clientes = _controladorVenta.obtenerClientes();

                // Assert
                Assert.AreEqual(1, clientes.Count);
                Assert.AreEqual("Joel", clientes[0].Nombre);
            }

            [TestMethod]
            public void GetCliente_RetornaClienteCorrectoPorId()
            {
                // Act
                var cliente = _controladorVenta.getCliente(1);

                // Assert
                Assert.IsNotNull(cliente);
                Assert.AreEqual("Joel", cliente.Nombre);
            }

            [TestMethod]
            public void ObtenerProductos_RetornaProductosCorrectamente()
            {
                // Act
                var productos = _controladorVenta.getProductos();

                // Assert
                Assert.AreEqual(2, productos.Count);
                Assert.AreEqual("Producto A", productos[0].Nombre);
            }

            [TestMethod]
            public void GetProducto_RetornaProductoCorrectoPorId()
            {
                // Act
                var producto = _controladorVenta.getProducto(1);

                // Assert
                Assert.IsNotNull(producto);
                Assert.AreEqual("Producto A", producto.Nombre);
            }

            [TestMethod]
            public void AgregarVenta_AgregaVentaCorrectamente()
            {
                // Arrange
                var nuevaVenta = new Venta { ProductoId = 1, Cantidad = 1, PrecioUnitario = 100 };

                // Act
                _controladorVenta.agregarVenta(nuevaVenta);
                var preventa = _controladorVenta.ObtenerPreventa();

                // Assert
                Assert.AreEqual(3, preventa.Count); // Debería haber 3 ventas en la preventa
                Assert.AreEqual(1, preventa.Last().ProductoId);
            }

            [TestMethod]
            public void RealizarVenta_RealizaVentaCorrectamente()
            {
                // Act
                _controladorVenta.RealizarVenta(_cliente, _cajero, MetodoPago.TipoPago.Efectivo);

                // Assert
                Assert.AreEqual(2, Datos2.facturas.Count);
                var factura = Datos2.facturas.First();
                Assert.AreEqual("cajero@ejemplo.com", factura.IdVendedor);
                Assert.AreEqual(_cliente.Id.ToString(), factura.IdCliente);
                Assert.AreEqual(2, factura.Ventas.Count); // Se agregaron 2 ventas
            }

            [TestMethod]
            public void EliminarVenta_EliminaVentaCorrectamente()
            {
                // Act
                _controladorVenta.eliminarVenta(1);
                var preventa = _controladorVenta.ObtenerPreventa();

                // Assert
                Assert.AreEqual(1, preventa.Count); // Debería haber 1 venta restante
                Assert.AreEqual(2, preventa.First().ProductoId); // La venta restante debería ser la segunda
            }
        }
    }

}
