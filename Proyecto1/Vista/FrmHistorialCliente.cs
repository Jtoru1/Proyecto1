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
    public partial class FrmHistorialCliente : Form
    {
        private Cliente cliente;
        private ControladorHistorialCliente controladorhistorialcliente;

        public FrmHistorialCliente(Cliente cliente)
        {
            controladorhistorialcliente = new ControladorHistorialCliente();
            InitializeComponent();
            this.cliente = cliente;
            var ventas = controladorhistorialcliente.ObtenerHistorialVentas(this.cliente.Id);
            lbcliente.Text = "Cliente: " + cliente.Nombre + " " + cliente.Apellido;
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Producto ", 150);
            listView1.Columns.Add("Cantidad", 100);
            listView1.Columns.Add("Precio Unitario", 100);
            listView1.Columns.Add("Total", 150);


            listView1.Items.Clear();
            foreach (var factura in ventas)
            {
                var producto = controladorhistorialcliente.ObtenerProductoPorId(factura.ProductoId);
                ListViewItem item = new ListViewItem(factura.Id.ToString());
                item.SubItems.Add(producto.Nombre);
                item.SubItems.Add(factura.Cantidad.ToString());
                item.SubItems.Add(factura.PrecioUnitario.ToString());
                item.SubItems.Add(factura.Total.ToString());
                listView1.Items.Add(item);
            }
        }

        private void FrmHistorialCliente_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
