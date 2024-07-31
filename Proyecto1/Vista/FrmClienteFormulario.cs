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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto1.Vista
{
    public partial class FrmClienteFormulario : Form
    {
        private ControladorModificarCliente controladorModificarCliente; // Instancia del controlador Modificar Cliente


        public FrmClienteFormulario()
        {
            InitializeComponent();
            controladorModificarCliente = new ControladorModificarCliente(); // Inicializa el controlador modificar cliente
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmClienteFormulario_Load(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e) // Método en el botón para poder registrar un usuario
        {
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string direccion = txtdireccion.Text;
            string numero = txttelefono.Text;
            string correo = txtcorreo.Text;

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(direccion) ||
                string.IsNullOrWhiteSpace(numero) ||
                string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Cliente nuevoCliente = new Cliente
            {

                Nombre = nombre,
                Apellido = apellido,
                Direccion = direccion,
                Numero = numero,
                Correo = correo

            };
            controladorModificarCliente.AgregarCliente(nuevoCliente);
            var pantallaCliente = new FrmCliente(); // Permite acceder a la pantalla general de cliente 
            pantallaCliente.Show();
            this.Hide();


        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Verifica que solamente se escriban números y no letras u otros caracteres 
            {
                e.Handled = true;
            }
        }
    }
}
