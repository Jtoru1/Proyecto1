﻿using Proyecto1.Controlador;
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
using static Proyecto1.Modelo.MetodoPago;

namespace Proyecto1.Vista
{
    public partial class FrmReporte : Form
    {
        private ControladorReportes controladorReportes; // Instancia el controlador de reportes 
        public FrmReporte()
        {
            InitializeComponent();
            controladorReportes = new ControladorReportes(); // Inicializa el controlador de reportes 
            this.Load += FrmVenta_load;

        }


        private void FrmVenta_load(object sender, EventArgs e)
        {
            var listaFacturas = controladorReportes.ObtenerFacturas();
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 50);
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
            var meses = new List<Mes> // Variable para agregar los meses del año 
        {
            new Mes(1, "Enero"),
            new Mes(2, "Febrero"),
            new Mes(3, "Marzo"),
            new Mes(4, "Abril"),
            new Mes(5, "Mayo"),
            new Mes(6, "Junio"),
            new Mes(7, "Julio"),
            new Mes(8, "Agosto"),
            new Mes(9, "Septiembre"),
            new Mes(10, "Octubre"),
            new Mes(11, "Noviembre"),
            new Mes(12, "Diciembre")
        };

                                            
            cbmeses.DataSource = meses; // Asignar la lista de meses al ComboBox usando DataSource
            cbmeses.DisplayMember = "Nombre"; // Muestr el nombre del mes en combobox
            cbmeses.ValueMember = "Numero"; // Muestra el número del mes en el combobox 



          
            for (int year = DateTime.Now.Year - 10; year <= DateTime.Now.Year; year++)
            {
                cbanos.Items.Add(year);
            }
            cbanos.SelectedItem = DateTime.Now.Year;
            // Eventos para cuando cambian los valores en los ComboBox
            cbmeses.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            cbanos.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            dateTimePicker1.ValueChanged += DateTimePicker_ValueChanged;

        }

        private void FrmReporte_Load_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            cbmeses.Visible = false; // Oculta el combobox de meses 
            cbanos.Visible = false; // Oculta el combobox de años 
            dateTimePicker1.Visible = false; // Oculta el calendario
            var clientesConMayoresCompras = controladorReportes.ObtenerClientesConMayoresCompras();
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("ID Cliente", 150);
            listView1.Columns.Add("Nombre del Cliente", 250);
            listView1.Columns.Add("Total Compras", 150);

            
            foreach (var cliente in clientesConMayoresCompras)
            {
                ListViewItem item = new ListViewItem(cliente.IdCliente);
                var objetoCliente = controladorReportes.ObtenerClientePorId(int.Parse(cliente.IdCliente));
                item.SubItems.Add(objetoCliente.Nombre + " " + objetoCliente.Apellido);
                item.SubItems.Add(cliente.TotalCompras.ToString("F2"));
                listView1.Items.Add(item);
            }


        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            cbmeses.Visible = false;
            cbanos.Visible = false;
            dateTimePicker1.Visible = false;
            var vendedoresConMayoresVentas = controladorReportes.ObtenerVendedoresConMayoresVentas();

            listView1.Items.Clear();  // Limpiar la ListView


            listView1.Columns.Clear();
            listView1.Columns.Add("ID Vendedor", 250);
            listView1.Columns.Add("Total Ventas", 150);


            foreach (var vendedor in vendedoresConMayoresVentas)
            {
                ListViewItem item = new ListViewItem(vendedor.IdVendedor); // Crea una nueva listview con el ID de vendedor 
                item.SubItems.Add(vendedor.TotalVentas.ToString("F2"));
                listView1.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Mes mes = (Mes)cbmeses.SelectedItem; // Obtiene el mes seleccionado del combobox 
            int anio = (int)cbanos.SelectedItem; // obtiene el año seleccionado del combobox 
            var reporte = controladorReportes.ObtenerVentasPorMesYAño(mes.Numero, anio); // Obtiene el reporte de ventas para el mes y año 
            listView1.View = View.Details; // Muestra los detalle de la listview
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Método de pago", 175);
            listView1.Columns.Add("Fecha de factura", 250);
            listView1.Columns.Add("Monto Total", 150);

            listView1.Items.Clear(); // Actualiza los nuevos datos 
            foreach (var factura in reporte) // Recorre cada factura en el reporte y agregar los datos al listview 
            {
                ListViewItem item = new ListViewItem(factura.Id.ToString()); // Crea un nuevo item en la listview para cada factura 
                item.SubItems.Add(factura.MetodoPago.ToString());
                item.SubItems.Add(factura.Fecha.ToString());
                item.SubItems.Add(factura.Total.ToString());


                listView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear(); // Limpiar la ListView
            dateTimePicker1.Visible = false; // Esconde el calendario de la pantalla 
            cbmeses.Visible = true; // muestra el combobox de los meses 
            cbanos.Visible = true; // Muestra el combo box de los años 
        }

        private void btnfiltrofechas_Click(object sender, EventArgs e)
        {
            // Limpiar la ListView
            listView1.Items.Clear();
            dateTimePicker1.Visible = true; // Muestra el calendario de la pantalla
            cbmeses.Visible = false; // Esconde el combobox de los meses 
            cbanos.Visible = false; // Esconde el combo box de los años 
        }
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

            DateTime fechaSeleccionada = dateTimePicker1.Value.Date; // Obtiene la fecha seleccionada 


            GenerarReportePorFecha(fechaSeleccionada); // Genera el reporte por fecha 
        }
        private void GenerarReportePorFecha(DateTime fecha)
        {

            listView1.Items.Clear(); // Limpiar el listview 


            var facturasDeLaFecha = controladorReportes.ObtenerVentasPorFecha(fecha); // Obtiene las facturas de la fecha seleccionada 

            listView1.View = View.Details; // Mostrar las facturas en el ListView
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Método de pago", 175);
            listView1.Columns.Add("Fecha de factura", 250);
            listView1.Columns.Add("Monto Total", 150);

            listView1.Items.Clear();
            foreach (var factura in facturasDeLaFecha)
            {
                ListViewItem item = new ListViewItem(factura.Id.ToString());
                item.SubItems.Add(factura.MetodoPago.ToString());
                item.SubItems.Add(factura.Fecha.ToString());
                item.SubItems.Add(factura.Total.ToString());


                listView1.Items.Add(item);
            }
        }
    }
}
