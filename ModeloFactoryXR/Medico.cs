using System.ComponentModel.DataAnnotations;

namespace ModeloFactoryXR
{
    public abstract class Medico
    {
        public abstract int PacientesMinimosAtender();
        public abstract string Servicio(int tipo);
        public abstract string Cargo();
    }
}
