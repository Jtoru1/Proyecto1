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
    public partial class FrmReporte : Form
    {
        private ControladorReportes ControladorReportes;
        public FrmReporte()
        {
            InitializeComponent();
            ControladorReportes = new ControladorReportes();
            this.Load += FrmVenta_load;
        }


        private void FrmVenta_load(object sender, EventArgs e)
        {
            var listaFacturas = ControladorReportes.ObtenerFacturas();
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 50);
            //listView1.Columns.Add("Producto", 100);
            //listView1.Columns.Add("Cantidad", 100);
            listView1.Columns.Add("Método de pago", 175);
            listView1.Columns.Add("Fecha de factura", 250);
            listView1.Columns.Add("Monto Total", 150);
            
            listView1.Items.Clear();
            foreach (var factura in listaFacturas)
            {
                ListViewItem item = new ListViewItem(factura.Id.ToString());
                item.SubItems.Add(factura.MetodoPago.ToString());
                item.SubItems.Add(factura.Fecha.ToString());
                item.SubItems.Add(factura.Total.ToString());
               

                listView1.Items.Add(item);
            }

        }

        private void FrmReporte_Load_1(object sender, EventArgs e)
        {

        }
    }
}
