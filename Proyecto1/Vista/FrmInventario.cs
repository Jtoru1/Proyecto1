using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto1.Controlador;
using Proyecto1.Datos;
using Proyecto1.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto1.Vista
{
    public partial class FrmInventario : Form
    {
        private ControladorProducto controladorProducto;
        public FrmInventario()
        {
            InitializeComponent();
            this.FormClosed += FrmInicio_FormClosed;
            controladorProducto = new ControladorProducto();
            this.Load += FrmProducto_Load;
            listView1.MultiSelect = true;
            listView1.FullRowSelect = true;
        }
        private void FrmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            var listaProductos = controladorProducto.obtenerProductos();
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Nombre", 150);
            listView1.Columns.Add("Descripción", 150);
            listView1.Columns.Add("Precio", 100);
            listView1.Columns.Add("Cantidad", 100);
            listView1.Columns.Add("Nivel de inventario", 200);
            listView1.Items.Clear();
            foreach (var producto in listaProductos)
            {
                ListViewItem item = new ListViewItem(producto.Id.ToString());
                item.SubItems.Add(producto.Nombre);
                item.SubItems.Add(producto.Descripcion);
                item.SubItems.Add(producto.Precio.ToString());
                item.SubItems.Add(producto.Cantidad.ToString());
                item.SubItems.Add(controladorProducto.VerificarInventarioBajo(producto));
              
                listView1.Items.Add(item);
            }

        }
        private void btnarticulo_Click(object sender, EventArgs e)
        {
            var nuevaPantalla = new FrmProductoFormulario();
            nuevaPantalla.Show();
            this.Hide();

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string id = selectedItem.SubItems[0].Text;
                var producto = controladorProducto.GetProducto(int.Parse(id));
                if (producto != null)
                {
                    var nuevaPantalla = new FrmEditarProducto(producto);
                    nuevaPantalla.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Por favor seleccione un elemento.");
            }

        }


        private void FrmVenta_Load(object sender, EventArgs e)
        {

        }

        private void listviewarticulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            var listaProductos = controladorProducto.obtenerProductos();
            if (listView1.SelectedItems.Count > 0)
            {

                foreach (ListViewItem item in listView1.SelectedItems)
                {

                    int id = int.Parse(item.SubItems[0].Text);
                    var producto = listaProductos.FirstOrDefault(c => c.Id == id);
                    if (producto != null)
                    {
                        listaProductos.Remove(producto);
                    }


                    listView1.Items.Remove(item);
                }
                controladorProducto.ActualizarListaProducto();
                MessageBox.Show("Producto eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("Seleccione al menos un Producto para eliminar.");
            }
        }
    }
}
