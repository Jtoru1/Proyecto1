using Proyecto1.Controlador;
using Proyecto1.Datos;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Proyecto1.Modelo.MetodoPago;

namespace TestControladores
{
    [TestClass]
    public class ControladorReportesTests
    {
        private ControladorReportes _controladorReportes;

        [TestInitialize]
        public void Setup()
        {
           
            Datos2.facturas = new List<Factura>
    {
        new Factura
        {
            Id = 1,
            IdCliente = "C1",
            Fecha = new DateTime(2024, 8, 1),
            Ventas = new List<Venta>
            {
                new Venta { ProductoId = 101, Cantidad = 2, PrecioUnitario = 50.0 }
            },
            MetodoPago = TipoPago.Efectivo,
            IdVendedor = "V1"
        },
        new Factura
        {
            Id = 2,
            IdCliente = "C2",
            Fecha = new DateTime(2024, 8, 15),
            Ventas = new List<Venta>
            {
                new Venta { ProductoId = 102, Cantidad = 4, PrecioUnitario = 50.0 }
            },
            MetodoPago = TipoPago.Tarjeta,
            IdVendedor = "V1"
        },
        new Factura
        {
            Id = 3,
            IdCliente = "C1",
            Fecha = new DateTime(2024, 7, 10),
            Ventas = new List<Venta>
            {
                new Venta { ProductoId = 103, Cantidad = 3, PrecioUnitario = 50.0 }
            },
            MetodoPago = TipoPago.Transferencia,
            IdVendedor = "V2"
        }
    };
            _controladorReportes = new ControladorReportes();
        }

        [TestMethod]
        public void ObtenerFacturas_RetornaListaDeFacturas()
        {
            // Act
            var facturas = _controladorReportes.ObtenerFacturas();

            // Assert
            Assert.AreEqual(3, facturas.Count);
        }

        [TestMethod]
        public void ObtenerVentasPorFecha_FechaExistente_RetornaFacturasCorrectas()
        {
            // Act
            var facturas = _controladorReportes.ObtenerVentasPorFecha(new DateTime(2024, 8, 1));

            // Assert
            Assert.AreEqual(1, facturas.Count);
        }

        [TestMethod]
        public void ObtenerVentasPorFecha_FechaNoExistente_RetornaListaVacia()
        {
            // Act
            var facturas = _controladorReportes.ObtenerVentasPorFecha(new DateTime(2024, 8, 20));

            // Assert
            Assert.AreEqual(0, facturas.Count);
        }

        [TestMethod]
        public void ObtenerVentasPorMesYAño_RetornaFacturasCorrectas()
        {
            // Act
            var facturas = _controladorReportes.ObtenerVentasPorMesYAño(8, 2024);

            // Assert
            Assert.AreEqual(2, facturas.Count);
        }

        [TestMethod]
        public void ObtenerVendedoresConMayoresVentas_RetornaVendedoresOrdenadosPorVentas()
        {
            // Act
            var vendedores = _controladorReportes.ObtenerVendedoresConMayoresVentas();

            // Assert
            Assert.AreEqual(2, vendedores.Count);
            Assert.AreEqual("V1", vendedores[0].IdVendedor);
            Assert.AreEqual(300.0, vendedores[0].TotalVentas);
            Assert.AreEqual("V2", vendedores[1].IdVendedor);
            Assert.AreEqual(150.0, vendedores[1].TotalVentas);
        }

        [TestMethod]
        public void ObtenerClientesConMayoresCompras_RetornaClientesOrdenadosPorCompras()
        {
            // Act
            var clientes = _controladorReportes.ObtenerClientesConMayoresCompras();

            // Assert
            Assert.AreEqual(2, clientes.Count);
            Assert.AreEqual("C1", clientes[0].IdCliente);
            Assert.AreEqual(250.0, clientes[0].TotalCompras);
            Assert.AreEqual("C2", clientes[1].IdCliente);
            Assert.AreEqual(200.0, clientes[1].TotalCompras);
           
        }

        [TestMethod]
        
        public void ObtenerClientePorId_IdNoExistente()
        {
            // Arrange
           

            // Act
            var cliente = _controladorReportes.ObtenerClientePorId(99);

            // Assert
            Assert.IsNull(cliente);
        }
    }

}
