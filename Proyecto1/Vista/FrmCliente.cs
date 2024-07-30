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
        private ControladorCliente controladorCliente;
        public FrmCliente()
        {
            InitializeComponent();
            this.FormClosed += FrmInicio_FormClosed;
            controladorCliente = new ControladorCliente();
            this.Load += FrmCliente_Load;
            listView1.MultiSelect = true;
            listView1.FullRowSelect = true;
        }
        private void FrmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevaPantalla = new FrmClienteFormulario();
            nuevaPantalla.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string id = selectedItem.SubItems[0].Text;
                var cliente = controladorCliente.getCliente(int.Parse(id));
                if (cliente != null)
                {
                    var nuevaPantalla = new FrmEditarUsuario(cliente);
                    nuevaPantalla.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Por favor seleccione un elemento.");
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var listaClientes = controladorCliente.obtenerClientes();
            if (listView1.SelectedItems.Count > 0)
            {

                foreach (ListViewItem item in listView1.SelectedItems)
                {

                    int id = int.Parse(item.SubItems[0].Text);
                    var cliente = listaClientes.FirstOrDefault(c => c.Id == id);
                    if (cliente != null)
                    {
                        listaClientes.Remove(cliente);
                    }


                    listView1.Items.Remove(item);
                }
                controladorCliente.ActualizarListaCliente();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string id = selectedItem.SubItems[0].Text;
                var cliente = controladorCliente.getCliente(int.Parse(id));
                if (cliente != null)
                {
                    var nuevaPantalla = new FrmHistorialCliente(cliente);
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
