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
        // public event EventHandler LoginClicked;
        private Cajero cajero;
        public FrmInicio(Cajero cajero)
        {
            InitializeComponent();
            this.cajero = cajero;
            this.FormClosed += FrmInicio_FormClosed;
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            lbCajero.Text = $"Cajero {cajero.Nombre}";
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

            var nuevaPantalla = new FrmCliente();
            nuevaPantalla.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nuevaPantalla = new FrmInventario();
            nuevaPantalla.Show();

        }

        private void btnInventarios_Click(object sender, EventArgs e)
        {
            var nuevaPantalla = new FrmFacturacion(this.cajero);
            nuevaPantalla.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var nuevaPantalla = new FrmReporte();
            nuevaPantalla.Show();
        }
    }
}
