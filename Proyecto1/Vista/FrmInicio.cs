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
    public partial class FrmInicio : Form
    {
        
        private Cajero cajero;
        public FrmInicio(Cajero cajero)
        {
            InitializeComponent();
            this.cajero = cajero;
            this.FormClosed += FrmInicio_FormClosed; // Asigna el evento para cerrar la pantalla 
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            lbCajero.Text = $"Cajero {cajero.Nombre}"; // Muestra un mensaje con el nombre del cajero iniciado en la pantalla 
        }
        private void FrmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e) 
        {

            var nuevaPantalla = new FrmCliente(); // Muestra la pantalla de cliente 
            nuevaPantalla.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nuevaPantalla = new FrmInventario(); // Muestra la pantalla de inventario
            nuevaPantalla.Show();

        }

        private void btnInventarios_Click(object sender, EventArgs e)
        {
            var nuevaPantalla = new FrmFacturacion(this.cajero); // Muestra la pantalla de Facturación 
            nuevaPantalla.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var nuevaPantalla = new FrmReporte(); // muestra la pantalla de Reporte
            nuevaPantalla.Show();
        }
    }
}
