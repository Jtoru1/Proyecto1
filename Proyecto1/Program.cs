using System;
using System.Windows.Forms;
using Proyecto1.Modelo; 
using Proyecto1.Controlador;
using Proyecto1.Vista;

namespace Proyecto1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           // var userModel = new Model();
            //var loginForm = new Form1();
           //var controlador = new LoginController(loginForm, userModel);

            Application.Run(new FrmLogin());

        }

    }
}