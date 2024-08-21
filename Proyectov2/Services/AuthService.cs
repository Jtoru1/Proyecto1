
using Proyecto1.Modelo; // Asegúrate de que esta referencia es válida en tu proyecto web.
using Proyecto1.Controlador;
using System.Threading.Tasks;
using Proyectov2.Services;

namespace Proyectov2.Services; // Cambia "TuProyectoWeb" por el nombre de tu proyecto


    public class AuthService
    {
        private readonly LoginController _loginController;

        public AuthService(LoginController loginController)
        {
            _loginController = loginController;
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            // Llama al método de autenticación del controlador
            bool isAuthenticated = _loginController.autenticarUsuario(username, password);

            if (isAuthenticated)
            {
                // Aquí podrías almacenar el cajero autenticado en una variable de sesión o similar
                return true;
            }
            return false;
        }

    }




