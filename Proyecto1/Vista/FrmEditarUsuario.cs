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
    public partial class FrmEditarUsuario : Form
    {
        private ControladorEditarCliente controladorEditarCliente; // Instancia el controlador editar cliente
        private Cliente clientePorEditar;
        public FrmEditarUsuario(Cliente cliente)
        {
            InitializeComponent();
            clientePorEditar = cliente;
            controladorEditarCliente = new ControladorEditarCliente(); // Inicaliza el controlador editar cliente 
            txteditarnombre.Text = cliente.Nombre;
            txteditarapellido.Text = cliente.Apellido;
            txteditardireccion.Text = cliente.Direccion;
            txteditartelefono.Text = cliente.Numero;
            txteditarcorreo.Text = cliente.Correo;
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e) // Se encarga de guardar todos los datos ya editados 
        {
            string nombre = txteditarnombre.Text;
            string apellido = txteditarapellido.Text;
            string direccion = txteditardireccion.Text;
            string numero = txteditartelefono.Text;
            string correo = txteditarcorreo.Text;

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(direccion) ||
                string.IsNullOrWhiteSpace(numero) ||
                string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cliente clientePorEditar = new Cliente // Crea una instancia del cliente con los clientes editados 
            {
                Id = this.clientePorEditar.Id, // Mantiene el id del cliente 
                Nombre = nombre,
                Apellido = apellido,
                Direccion = direccion,
                Numero = numero,
                Correo = correo

            };
            controladorEditarCliente.editarCliente(clientePorEditar);// Llama al método para guardar los cambios 
            var pantallaCliente = new FrmCliente();
            pantallaCliente.Show();
            this.Hide();

        }

        private void txteditartelefono_KeyPress(object sender, KeyPressEventArgs e) // Se encarga de que solamente se escriban números y no letras o caracteres
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
