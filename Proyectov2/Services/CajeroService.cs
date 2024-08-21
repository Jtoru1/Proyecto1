using Proyecto1.Modelo;

namespace Proyectov2.Services
{

    public class CajeroService
    {
        public Cajero CajeroActual { get; private set; }

        public void SetCajeroActual(Cajero cajero)
        {
            CajeroActual = cajero;
        }

        public Cajero GetCajeroActual()
        {
            return CajeroActual;
        }
    }
}
