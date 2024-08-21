using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4j.Driver;
using Proyecto1.Modelo;
namespace Proyecto1.Datos
{
    internal class Neo4jBD
    {
        public class Neo4jConnection : IDisposable
        {
            private readonly IDriver _driver;

            public Neo4jConnection(string uri, string user, string password)
            {
                _driver = GraphDatabase.Driver(uri, AuthTokens.Basic(user, password));
            }

            public async Task<List<IRecord>> RunQueryAsync(string query, object parameters = null)
            {
                var session = _driver.AsyncSession();
                try
                {
                    var result = await session.RunAsync(query, parameters);
                    return await result.ToListAsync();
                }
                finally
                {
                    await session.CloseAsync();
                }
            }

            public void Dispose()
            {
                _driver?.Dispose();
            }
            public async Task AgregarClienteAsync(Cliente cliente)
            {
                var query = $@"
            CREATE (c:Cliente {{
                id: {cliente.Id},
                nombre: '{cliente.Nombre}',
                apellido: '{cliente.Apellido}',
                direccion: '{cliente.Direccion}',
                numero: '{cliente.Numero}',
                correo: '{cliente.Correo}'
            }})";

                await RunQueryAsync(query);
            }

            public async Task AgregarProductoAsync(Producto producto)
            {
                var query = $@"
            CREATE (p:Producto {{
                id: {producto.Id},
                nombre: '{producto.Nombre}',
                descripcion: '{producto.Descripcion}',
                precio: {producto.Precio},
                cantidad: {producto.Cantidad}
            }})";

                await RunQueryAsync(query);
            }
            public async Task EliminarClienteAsync(int clienteId)
            {
                var query = $@"
            MATCH (c:Cliente {{id: {clienteId}}})
            DETACH DELETE c";

                await RunQueryAsync(query);
            }

            public async Task EliminarProductoAsync(int productoId)
            {
                var query = $@"
            MATCH (p:Producto {{id: {productoId}}})
            DETACH DELETE p";

                await RunQueryAsync(query);
            }
            public async Task ActualizarClientesAsync(IEnumerable<Cliente> clientes)
            {
                // Eliminar todos los nodos Cliente
                var eliminarQuery = @"
            MATCH (c:Cliente)
            DETACH DELETE c";
                await RunQueryAsync(eliminarQuery);

                // Agregar nuevos nodos Cliente
                var agregarQuery = @"
            CREATE (c:Cliente {id: $id, nombre: $nombre, apellido: $apellido, direccion: $direccion, numero: $numero, correo: $correo})";

                foreach (var cliente in clientes)
                {
                    var parameters = new
                    {
                        id = cliente.Id,
                        nombre = cliente.Nombre,
                        apellido = cliente.Apellido,
                        direccion = cliente.Direccion,
                        numero = cliente.Numero,
                        correo = cliente.Correo
                    };

                    await RunQueryAsync(agregarQuery, parameters);
                }
            }

            public async Task ActualizarProductosAsync(IEnumerable<Producto> productos)
            {
                // Eliminar todos los nodos Producto
                var eliminarQuery = @"
            MATCH (p:Producto)
            DETACH DELETE p";
                await RunQueryAsync(eliminarQuery);

                // Agregar nuevos nodos Producto
                var agregarQuery = @"
            CREATE (p:Producto {id: $id, nombre: $nombre, descripcion: $descripcion, precio: $precio, cantidad: $cantidad})";

                foreach (var producto in productos)
                {
                    var parameters = new
                    {
                        id = producto.Id,
                        nombre = producto.Nombre,
                        descripcion = producto.Descripcion,
                        precio = producto.Precio,
                        cantidad = producto.Cantidad
                    };

                    await RunQueryAsync(agregarQuery, parameters);
                }
            }
            public async Task AgregarFacturaAsync(Factura factura)
            {
                // Eliminar nodos de factura existentes (opcional)
                var eliminarQuery = @"
    MATCH (f:Factura)
    WHERE f.id = $id
    DETACH DELETE f";
                await RunQueryAsync(eliminarQuery, new { id = factura.Id });

                // Crear nodo de factura
                var crearFacturaQuery = @"
    CREATE (f:Factura {id: $id, IdCliente: $IdCliente, fecha: $fecha, metodoPago: $metodoPago, total: $total, idVendedor: $idVendedor})
    RETURN f";
                var facturaParameters = new
                {
                    id = factura.Id,
                    IdCliente = factura.IdCliente,
                    fecha = factura.Fecha.ToString("yyyy-MM-dd"),
                    metodoPago = factura.MetodoPago.ToString(),
                    total = factura.Total,
                    idVendedor = factura.IdVendedor
                };
                await RunQueryAsync(crearFacturaQuery, facturaParameters);

                // Relacionar la factura con el cliente
                var relacionClienteQuery = @"
    MATCH (f:Factura {id: $idFactura}), (c:Cliente {id: $idCliente})
    CREATE (f)-[:EMITIDA_POR]->(c)";
                await RunQueryAsync(relacionClienteQuery, new { idFactura = factura.Id, idCliente = factura.IdCliente });

                // Relacionar la factura con el cajero
                var relacionCajeroQuery = @"
    MATCH (f:Factura {id: $idFactura}), (c:Cajero {id: $idVendedor})
    CREATE (f)-[:ATENDIDA_POR]->(c)";
                await RunQueryAsync(relacionCajeroQuery, new { idFactura = factura.Id, idVendedor = factura.IdVendedor });

                // Crear y relacionar ventas con la factura y productos
                foreach (var venta in factura.Ventas)
                {
                    // Generar un nuevo ID único para cada venta
                     // Asegúrate de que cada venta tenga un ID único

                    // Crear nodo de venta
                    var crearVentaQuery = @"
        CREATE (v:Venta {id: $id, productoId: $productoId, cantidad: $cantidad, precioUnitario: $precioUnitario, total: $total})
        RETURN v";
                    var ventaParameters = new
                    {
                        id = venta.Id,
                        productoId = venta.ProductoId,
                        cantidad = venta.Cantidad,
                        precioUnitario = venta.PrecioUnitario,
                        total = venta.Total
                    };
                    await RunQueryAsync(crearVentaQuery, ventaParameters);

                    // Relacionar venta con producto
                    var relacionProductoQuery = @"
        MATCH (v:Venta {id: $idVenta}), (p:Producto {id: $productoId})
        CREATE (v)-[:CONTENIDO_EN]->(p)";
                    await RunQueryAsync(relacionProductoQuery, new { idVenta = venta.Id, productoId = venta.ProductoId });

                    // Relacionar venta con factura
                    var relacionFacturaQuery = @"
        MATCH (f:Factura {id: $idFactura}), (v:Venta {id: $idVenta})
        CREATE (f)-[:INCLUYE]->(v)";
                    await RunQueryAsync(relacionFacturaQuery, new { idFactura = factura.Id, idVenta = venta.Id });
                }
            }

        }
    }
}
