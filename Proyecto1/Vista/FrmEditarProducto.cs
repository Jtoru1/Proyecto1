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
    public partial class FrmEditarProducto : Form
    {
        private ControladorEditarProducto controladorEditarProducto; // Instancia el controlador editar producto 
        private Producto productoPorEditar;
        public FrmEditarProducto(Producto producto)
        {
            InitializeComponent();
            productoPorEditar = producto;
            controladorEditarProducto = new ControladorEditarProducto(); // Inicializa el contrlador de editar productos 
            txteditarnombre.Text = producto.Nombre;
            txteditardescripcion.Text = producto.Descripcion;
            txteditarprecio.Text = producto.Precio.ToString();
            txteditarcantidad.Text = producto.Cantidad.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btneditardatos_Click(object sender, EventArgs e)
        {
            string nombre = txteditarnombre.Text;
            string descripcion = txteditardescripcion.Text;
            string precio = txteditarprecio.Text;
            string cantidad = txteditarcantidad.Text;

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(descripcion) ||
                string.IsNullOrWhiteSpace(precio) ||
                string.IsNullOrWhiteSpace(cantidad))

            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Producto ProductoPorEditar = new Producto // Crea una instancia del producto con los datos editados 
            {
                Id = this.productoPorEditar.Id, // Mantiene el mismo id del producto 
                Nombre = nombre,
                Descripcion = descripcion,
                Precio = Utilidades.Utilidades.StrToDoubleConDefault(precio, 0),
                Cantidad = Utilidades.Utilidades.StrToIntConDefault(cantidad, 0)


            };
            controladorEditarProducto.editarProducto(ProductoPorEditar); // Llama al método para guardar los cambios
            var pantallaCliente = new FrmInventario();
            pantallaCliente.Show();
            this.Hide();
        }

        private void txteditarprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txteditarcantidad_KeyPress(object sender, KeyPressEventArgs e) // Se encarga de que solamente se escriban números y no letras o caracteres
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
