using Proyecto1.Controlador;
using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Vista
{
    public partial class FrmProductoFormulario : Form
    {
        private ControladorModificarProducto controladorModificarProducto;
        public FrmProductoFormulario()
        {
            InitializeComponent();
            controladorModificarProducto = new ControladorModificarProducto();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string descripcion = txtdescripcion.Text;
            string precio = txtprecio.Text;
            string cantidad = txtcantidad.Text;


            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(descripcion) ||
                string.IsNullOrWhiteSpace(precio) ||
                string.IsNullOrWhiteSpace(cantidad))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Producto nuevoProducto = new Producto
            {

                Nombre = nombre,
                Descripcion = descripcion,
                Precio = Utilidades.Utilidades.StrToDoubleConDefault(precio, 0),
                Cantidad = Utilidades.Utilidades.StrToIntConDefault(cantidad, 0)

            };
            controladorModificarProducto.AgregarProducto(nuevoProducto);
            var pantallaCliente = new FrmInventario();
            pantallaCliente.Show();
            this.Hide();
        }

        private void FrmProductoFormulario_Load(object sender, EventArgs e)
        {

        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo permitir un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
