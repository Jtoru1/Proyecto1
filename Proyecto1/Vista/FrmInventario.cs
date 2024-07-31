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
        private ControladorProducto controladorProducto; // instacia el controlador de producto 
        public FrmInventario()
        {
            InitializeComponent();
            this.FormClosed += FrmInicio_FormClosed;
            controladorProducto = new ControladorProducto(); // Inicializa el controlador de producto 
            this.Load += FrmProducto_Load;
            listView1.MultiSelect = true; // Permite seleccionar multiples opciones en la listview 
            listView1.FullRowSelect = true; // permite selecionar una fila completa en la listview 
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
            var nuevaPantalla = new FrmProductoFormulario(); // Muestra la pantalla de Producto Formulario 
            nuevaPantalla.Show();
            this.Hide();

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)  // Verifica si se ha seleccionado un item en la listview 
            {
                ListViewItem selectedItem = listView1.SelectedItems[0]; // Obtiene el item seleccionado
                string id = selectedItem.SubItems[0].Text;// Saca el id del producto 
                var producto = controladorProducto.GetProducto(int.Parse(id)); // Obtiene el producto correspondiente al id 
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
            var listaProductos = controladorProducto.obtenerProductos(); // Obtiene la lista de productos 
            if (listView1.SelectedItems.Count > 0) // Verifica que se haya seleccionado un item
            {

                foreach (ListViewItem item in listView1.SelectedItems) // Itera a través de cadaitem seleccionado 
                {

                    int id = int.Parse(item.SubItems[0].Text); // saca el id del producto 
                    var producto = listaProductos.FirstOrDefault(c => c.Id == id);
                    if (producto != null)
                    {
                        listaProductos.Remove(producto); // Elmina el producto de la lista de productos 
                    }


                    listView1.Items.Remove(item); // Eliminar el producto seleccionado de la listview 
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
