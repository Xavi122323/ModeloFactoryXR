namespace ModeloFactoryXR
{
    public class Especialista : Medico
    {
        public override int PacientesMinimosAtender()
        {
            return 20;
        }
        public override string Servicio(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return "UCI pediátrica";
                case 2:
                    return "UCI adultos";
                case 3:
                    return "Cirugía";
                case 4:
                    return "Infectología";
                default: return "Sin servicio";
            }
        }
        public override string Cargo()
        {
            return "Especialista";
        }
    }
}
