using Proyecto1.Controlador;
using Proyecto1.Datos;
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
    public partial class FrmCliente : Form
    {
        private ControladorCliente controladorCliente; // Instancia del controlador cliente 
        public FrmCliente()
        {
            InitializeComponent();
            this.FormClosed += FrmInicio_FormClosed; // asigna el evento para cerrar el formulario
            controladorCliente = new ControladorCliente(); // Inicializa el controlador de clientes 
            this.Load += FrmCliente_Load;//asigna el evento para cargar el formulario
            listView1.MultiSelect = true; // Permite la selección multiple en la listview
            listView1.FullRowSelect = true; // Permite seleccionar toda la fila en la listview
        }
        private void FrmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide(); // Esconde el formulario al cerrarlo
        }

        private void FrmCliente_Load(object sender, EventArgs e) // Carga de datos del cliente en la listview 
        {
            var listaClientes = controladorCliente.obtenerClientes();
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Nombre", 100);
            listView1.Columns.Add("Apellido", 100);
            listView1.Columns.Add("Dirección", 100);
            listView1.Columns.Add("Número", 100);
            listView1.Columns.Add("Correo", 150);
            listView1.Items.Clear();
            foreach (var cliente in listaClientes)
            {
                ListViewItem item = new ListViewItem(cliente.Id.ToString());
                item.SubItems.Add(cliente.Nombre);
                item.SubItems.Add(cliente.Apellido);
                item.SubItems.Add(cliente.Direccion);
                item.SubItems.Add(cliente.Numero);
                item.SubItems.Add(cliente.Correo);
                listView1.Items.Add(item);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e) // Método en el botón para agregar clientes 
        {
            var nuevaPantalla = new FrmClienteFormulario(); // Permite acceder a la pantalla de creación de clientes o Usuarios
            nuevaPantalla.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e) // Método en el botón para editar clientes 
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string id = selectedItem.SubItems[0].Text;
                var cliente = controladorCliente.getCliente(int.Parse(id)); // Obtiene el cliente seleccionado
                if (cliente != null)
                {
                    var nuevaPantalla = new FrmEditarUsuario(cliente); // Permite acceder a la pantalla de editar Usuarios o Clientes
                    nuevaPantalla.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Por favor seleccione un elemento.");
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e) //Método en el botón para eliminar clientes
        {
            var listaClientes = controladorCliente.obtenerClientes();
            if (listView1.SelectedItems.Count > 0)
            {

                foreach (ListViewItem item in listView1.SelectedItems)
                {

                    int id = int.Parse(item.SubItems[0].Text);
                    var cliente = listaClientes.FirstOrDefault(c => c.Id == id); // Encuentra al cliente por ID
                    if (cliente != null)
                    {
                        listaClientes.Remove(cliente); // Elimina al cliente de la lista 
                    }


                    listView1.Items.Remove(item); // Eliminar al cliente de la listview
                }
                controladorCliente.ActualizarListaCliente(); // Actualiza la lista de clientes 
                MessageBox.Show("Cliente eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("Seleccione al menos un cliente para eliminar.");
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Método para acceder al historial de compras del cliente 
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string id = selectedItem.SubItems[0].Text;
                var cliente = controladorCliente.getCliente(int.Parse(id));
                if (cliente != null)
                {
                    var nuevaPantalla = new FrmHistorialCliente(cliente); // Muestra una pantalla para ver el historial de clientes 
                    nuevaPantalla.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Por favor seleccione un Cliente.");
            }
        }
    }
}
