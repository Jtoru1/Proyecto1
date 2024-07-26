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
        private ControladorEditarProducto controladorEditarProducto;
        private Producto productoPorEditar;
        public FrmEditarProducto(Producto producto)
        {
            InitializeComponent();
            productoPorEditar = producto;
            controladorEditarProducto = new ControladorEditarProducto();
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

            Producto ProductoPorEditar = new Producto
            {
                Id = this.productoPorEditar.Id,
                Nombre = nombre,
                Descripcion = descripcion,
                Precio = Utilidades.Utilidades.StrToDoubleConDefault(precio,0),
                Cantidad = Utilidades.Utilidades.StrToIntConDefault(cantidad, 0)


            };
            controladorEditarProducto.editarProducto(ProductoPorEditar);
            var pantallaCliente = new FrmInventario();
            pantallaCliente.Show();
            this.Hide();
        }
    }
}
