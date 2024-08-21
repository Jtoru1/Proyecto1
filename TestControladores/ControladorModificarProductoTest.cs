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
    public class ControladorModificarProductoTest
    {
        private ControladorModificarProducto _controladorModificarProducto;

        [TestInitialize]
        public void Setup()
        {
            // Inicializa el controlador antes de cada prueba
            _controladorModificarProducto = new ControladorModificarProducto();

            // Inicializa la lista de productos en Datos2
            Datos2.productos = new List<Producto>();
        }

        [TestMethod]
        public void AgregarProducto_NuevoProducto_ProductoAgregadoCorrectamente()
        {
            // Arrange
            var nuevoProducto = new Producto
            {
                Nombre = "Martillo",
                Descripcion = "Martillo de acero",
                Precio = 25.50,
                Cantidad = 10
            };

            // Act
            _controladorModificarProducto.AgregarProducto(nuevoProducto);

            // Assert
            Assert.AreEqual(1, Datos2.productos.Count); // Verifica que se haya agregado un producto
            Assert.AreEqual("Martillo", Datos2.productos[0].Nombre);
            Assert.AreEqual("Martillo de acero", Datos2.productos[0].Descripcion);
            Assert.AreEqual(25.50, Datos2.productos[0].Precio);
            Assert.AreEqual(10, Datos2.productos[0].Cantidad);
        }

        [TestMethod]
        public void AgregarProducto_VariosProductos_ProductosAgregadosCorrectamente()
        {
            // Arrange
            var producto1 = new Producto
            {
                Nombre = "Destornillador",
                Descripcion = "Destornillador de estrella",
                Precio = 15.75,
                Cantidad = 50
            };

            var producto2 = new Producto
            {
                Nombre = "Llave Inglesa",
                Descripcion = "Llave inglesa ajustable",
                Precio = 30.00,
                Cantidad = 25
            };

            // Act
            _controladorModificarProducto.AgregarProducto(producto1);
            _controladorModificarProducto.AgregarProducto(producto2);

            // Assert
            Assert.AreEqual(2, Datos2.productos.Count); // Verifica que se hayan agregado dos productos

            // Verifica los datos del primer producto
            Assert.AreEqual("Destornillador", Datos2.productos[0].Nombre);
            Assert.AreEqual("Destornillador de estrella", Datos2.productos[0].Descripcion);

            // Verifica los datos del segundo producto
            Assert.AreEqual("Llave Inglesa", Datos2.productos[1].Nombre);
            Assert.AreEqual("Llave inglesa ajustable", Datos2.productos[1].Descripcion);
        }
    }

}
