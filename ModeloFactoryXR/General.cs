namespace ModeloFactoryXR
{
    public class General : Medico
    {
        public override int PacientesMinimosAtender()
        {
            return 30;
        }
        public override string Servicio(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return "Emergencia adultos";
                case 2:
                    return "Emergencia pediátrica";
                case 3:
                    return "Hospital del día";
                case 4:
                    return "Cuidados intermedios";
                default: return "Sin servicio";
            }
        }
        public override string Cargo()
        {
            return "General";
        }
    }
}
