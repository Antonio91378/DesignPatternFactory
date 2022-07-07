namespace DesignPatterns2.cap9
{
    public class ServicoSingleton
    {
        private static Servico servico = new Servico();
        public Servico Instancia
        {
            get
            {
                return servico;
            }
        }
    }
}