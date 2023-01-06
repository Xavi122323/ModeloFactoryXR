namespace ModeloFactoryXR
{
    public class Creador
    {
        public static Medico CrearMedico(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return new General();
                case 2:
                    return new Especialista();
                case 3:
                    return new Administrativo();
                default: return null;
            }


        }
    }
}
