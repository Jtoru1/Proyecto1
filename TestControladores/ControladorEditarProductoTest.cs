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
    public class ControladorEditarProductoTest
    {
        private ControladorEditarProducto _controladorEditarProducto;

        [TestInitialize]
        public void Setup()
        {
            // Inicializa Datos2 con un estado conocido
            Datos2.productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "ProductoOriginal", Descripcion = "Descripción Original", Precio = 10.0, Cantidad = 100 },
            new Producto { Id = 2, Nombre = "ProductoParaNoCambiar", Descripcion = "Descripción No Cambiar", Precio = 20.0, Cantidad = 200 }
        };

            _controladorEditarProducto = new ControladorEditarProducto();
        }

        [TestMethod]
        public void EditarProducto_CorrectamenteActualizaProductoEnDatos2()
        {
            // Arrange
            var productoAEditar = new Producto
            {
                Id = 1,
                Nombre = "ProductoEditado",
                Descripcion = "Descripción Editada",
                Precio = 15.0,
                Cantidad = 150
            };

            // Act
            _controladorEditarProducto.editarProducto(productoAEditar);

            // Assert
            var productoEditado = Datos2.ObtenerProductoPorId(productoAEditar.Id);
            Assert.IsNotNull(productoEditado);
            Assert.AreEqual("ProductoEditado", productoEditado.Nombre);
            Assert.AreEqual("Descripción Editada", productoEditado.Descripcion);
            Assert.AreEqual(15.0, productoEditado.Precio);
            Assert.AreEqual(150, productoEditado.Cantidad);
        }

        [TestMethod]
        public void EditarProducto_NoModificaProductoNoExistente()
        {
            // Arrange
            var productoNoExistente = new Producto
            {
                Id = 999,
                Nombre = "ProductoNoExistente",
                Descripcion = "Descripción No Existente",
                Precio = 999.0,
                Cantidad = 999
            };

            // Act
            _controladorEditarProducto.editarProducto(productoNoExistente);

            // Assert
            var productoOriginal = Datos2.ObtenerProductoPorId(1); // Obtener el producto original que debería mantenerse igual
            Assert.IsNotNull(productoOriginal);
            Assert.AreEqual("ProductoOriginal", productoOriginal.Nombre);
            Assert.AreEqual("Descripción Original", productoOriginal.Descripcion);
            Assert.AreEqual(10.0, productoOriginal.Precio);
            Assert.AreEqual(100, productoOriginal.Cantidad);
        }
    }

}
