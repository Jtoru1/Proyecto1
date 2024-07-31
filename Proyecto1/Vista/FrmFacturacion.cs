using Proyecto1.Controlador;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto1.Modelo.MetodoPago;

namespace Proyecto1.Vista
{
    public partial class FrmFacturacion : Form
    {
        private Cajero cajero; // Instancia la clase cajero 
        private ControladorVenta controladorVenta; // Instancia el controlador de venta 
        private ControladorProducto controladorProducto; // Instancia el controlador de producto 
        public FrmFacturacion(Cajero cajero)
        {
            InitializeComponent();
            this.cajero = cajero;
            controladorVenta = new ControladorVenta();
            controladorProducto = new ControladorProducto();
            CargarComboBoxClientes(); // Se encarga de llamar al método 
            CargarComboBoxTipoPago(); // Se encarga de llamar el método 
            CargarComboboxProducto(); // Se encarga de llamar al método 
            {

            };
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {

            lbcajero.Text = $"Bienvenido {cajero.Nombre}";

        }

        private void CargarComboBoxClientes() // Método para cargar el combobox de la lista de clientes 
        {
            cbclientes.DataSource = controladorVenta.obtenerClientes();
            cbclientes.DisplayMember = "Display";
            cbclientes.ValueMember = "Id";



        }
        private void CargarComboBoxTipoPago() // Método para cargar el combo box del método de pago 
        {
            cbtipopago.DataSource = Enum.GetValues(typeof(TipoPago));
        }
        private void CargarComboboxProducto()  // Método para cargar el combobox con el id y el correo del cliente
        {
            cbproducto.DataSource = controladorProducto.obtenerProductos();
            cbproducto.DisplayMember = "Display";
            cbproducto.ValueMember = "Id";

        }

        private void cbclientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbtipopago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarListaVentas() // Método para cargar la lista de ventas en la listview
        {
            var preventas = controladorVenta.ObtenerPreventa();


            listView1.View = View.Details;
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Producto", 100);
            listView1.Columns.Add("Cantidad", 100);
            listView1.Columns.Add("Precio Individual", 150);
            listView1.Columns.Add("Precio Total", 150);
            foreach (var venta in preventas)
            {
                var producto = controladorVenta.getProducto(venta.ProductoId);
                ListViewItem item = new ListViewItem(venta.Id.ToString());
                item.SubItems.Add(producto.Nombre);
                item.SubItems.Add(venta.Cantidad.ToString());
                item.SubItems.Add(venta.PrecioUnitario.ToString());
                item.SubItems.Add(venta.Total.ToString());
                listView1.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbproducto.SelectedItem == null)  // Verifica si se ha seleccionado un productto del combo box
            {
                MessageBox.Show("Por favor seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtcantidad.Text) || !int.TryParse(txtcantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Producto productoSeleccionado = (Producto)cbproducto.SelectedItem; // Obtiene el producto seleccionado del combo box
            if (productoSeleccionado.Cantidad < cantidad) // Verificar si hay disponibilidad del producto en el inventario 
            {
                MessageBox.Show("Modifique su cantidad de producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double total = cantidad * productoSeleccionado.Precio; // Calcula el total de la venta 
            var venta = new Venta(); // Crear una nueva venta con los datos actualizados 
            venta.Cantidad = cantidad;
            venta.ProductoId = productoSeleccionado.Id;
            venta.PrecioUnitario = productoSeleccionado.Precio;
            controladorVenta.agregarVenta(venta);
            CargarListaVentas(); // Actualiza la lista de ventas en la pantalla 


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbcajero_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0) // Verifica que haya el menos un item en la lista 
            {
                Cliente clienteSeleccionado = (Cliente)cbclientes.SelectedItem; // Obtiene el cliente seleccionado 
                MetodoPago.TipoPago metodoPago = (MetodoPago.TipoPago)cbtipopago.SelectedItem; // Obtiene el método de pago 
                controladorVenta.RealizarVenta(clienteSeleccionado, this.cajero, metodoPago);
                MessageBox.Show("Factura realizada correctamente.", "Factura Guardada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, agregue al menos un elemento a la factura.", "Validación fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
