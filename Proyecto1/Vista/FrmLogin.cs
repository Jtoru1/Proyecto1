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
using Proyecto1.Modelo;

namespace Proyecto1.Vista
{
    public partial class FrmLogin : Form
    {
        private LoginController loginController; // Instancia el controlador de inicio de sesión 
        public FrmLogin()
        {
            InitializeComponent();
            loginController = new LoginController(); // Inicializa el controlador de inicio de sesión 
            this.FormClosed += Form1_FormClosed;
        }

        public string cajero => txtCorreo.Text; // Obtiene el correo del cajero 
        public string Password => txtcontrasena.Text; // obtiene la contraseña del cajero 

        private void btninicio_Click(object sender, EventArgs e)
        {
            if (loginController.autenticarUsuario(cajero, Password))
            {
                var objetoCajero = loginController.obtenerCajero(cajero);
                
                this.Hide();
                var nuevaPantalla = new FrmInicio(objetoCajero); // muestr la pantalla de Inicio 
                nuevaPantalla.Show();

            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Sale de la apliación cuando se cierra la pantalla 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
