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
        private ControladorVenta controladorVenta;
        private ControladorProducto controladorProducto;
        public FrmFacturacion()
        {
            InitializeComponent();
            controladorVenta = new ControladorVenta();
            controladorProducto = new ControladorProducto();
            CargarComboBoxClientes();
            CargarComboBoxTipoPago();
            CargarComboboxProducto();
            {

            };
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {

        }

        private void CargarComboBoxClientes()
        {
            cbclientes.DataSource = controladorVenta.obtenerClientes();
            cbclientes.DisplayMember = "Display";
            cbclientes.ValueMember = "Id";



        }
        private void CargarComboBoxTipoPago()
        {
            cbtipopago.DataSource = Enum.GetValues(typeof(TipoPago));
        }
        private void CargarComboboxProducto()
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
        private void CargarListaVentas()
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
            if (cbproducto.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtcantidad.Text) || !int.TryParse(txtcantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Producto productoSeleccionado = (Producto)cbproducto.SelectedItem;
            if (productoSeleccionado.Cantidad < cantidad)
            {
                MessageBox.Show("Modifique su cantidad de producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double total = cantidad * productoSeleccionado.Precio;
            var venta = new Venta();
            venta.Cantidad = cantidad;
            venta.ProductoId = productoSeleccionado.Id;
            venta.PrecioUnitario = productoSeleccionado.Precio;
            controladorVenta.agregarVenta(venta);
            CargarListaVentas();


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
    }
}
