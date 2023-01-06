namespace ModeloFactoryXR
{
    public class Administrativo: Medico
    {
        public override int PacientesMinimosAtender()
        {
            return 0;
        }
        public override string Servicio(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return "Auditoría médica";
                case 2:
                    return "Derivaciones";
                case 3:
                    return "Jefatura de guardia";
                case 4:
                    return "Otros";
                default: return "Sin servicio";
            }
        }
        public override string Cargo()
        {
            return "Administrativo";
        }
    }
}
