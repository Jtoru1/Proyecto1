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
    public class ControladorProductoTests
    {
        private ControladorProducto _controladorProducto;

        [TestInitialize]
        public void Setup()
        {
            // Inicializa el controlador y la lista de productos antes de cada prueba
            _controladorProducto = new ControladorProducto();
            Datos2.productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Martillo", Cantidad = 10 },
            new Producto { Id = 2, Nombre = "Destornillador", Cantidad = 5 },
            new Producto { Id = 3, Nombre = "Llave Inglesa", Cantidad = 0 }
        };
        }

        [TestMethod]
        public void ObtenerProductos_RetornaListaDeProductos()
        {
            // Act
            var productos = _controladorProducto.obtenerProductos();

            // Assert
            Assert.AreEqual(3, productos.Count);
        }

        [TestMethod]
        public void GetProducto_IdExistente_RetornaProductoCorrecto()
        {
            // Act
            var producto = _controladorProducto.GetProducto(1);

            // Assert
            Assert.IsNotNull(producto);
            Assert.AreEqual("Martillo", producto.Nombre);
        }

        [TestMethod]
        public void GetProducto_IdNoExistente_RetornaNull()
        {
            // Act
            var producto = _controladorProducto.GetProducto(99);

            // Assert
            Assert.IsNull(producto);
        }

        [TestMethod]
        public void VerificarInventarioBajo_SinUnidades_RetornaMensajeSinUnidades()
        {
            // Arrange
            var producto = Datos2.productos.First(p => p.Id == 3);

            // Act
            var mensaje = _controladorProducto.VerificarInventarioBajo(producto);

            // Assert
            Assert.AreEqual("Sin unidades", mensaje.Trim());
        }

        [TestMethod]
        public void VerificarInventarioBajo_UnidadesBajas_RetornaMensajeUnidadesBajas()
        {
            // Arrange
            var producto = Datos2.productos.First(p => p.Id == 2);

            // Act
            var mensaje = _controladorProducto.VerificarInventarioBajo(producto);

            // Assert
            Assert.AreEqual("Unidades bajas", mensaje.Trim());
        }

        [TestMethod]
        public void VerificarInventarioBajo_UnidadesNormales_RetornaMensajeUnidadesNormales()
        {
            // Arrange
            var producto = Datos2.productos.First(p => p.Id == 1);

            // Act
            var mensaje = _controladorProducto.VerificarInventarioBajo(producto);

            // Assert
            Assert.AreEqual("Unidades normales", mensaje.Trim());
        }

        //[TestMethod]
        //public void EliminarProducto_ProductoExistente_EliminaProductoDeLista()
        //{
        //    // Act
        //    _controladorProducto.EliminarProducto(1);

        //    // Assert
        //    Assert.AreEqual(2, Datos2.productos.Count);
        //    Assert.IsNull(Datos2.productos.FirstOrDefault(p => p.Id == 1));
        //}

        [TestMethod]
        public void EliminarProducto_ProductoNoExistente_NoModificaLista()
        {
            // Act
            _controladorProducto.EliminarProducto(99);

            // Assert
            Assert.AreEqual(3, Datos2.productos.Count); // La lista debería mantenerse igual
        }
    }

}
