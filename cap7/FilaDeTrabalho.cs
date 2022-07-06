namespace DesignPatterns2.cap7
{
    public class FilaDeTrabalho
    {
        private List<IComando> Comandos = new List<IComando>();
        public void Adiciona(IComando comando)
        {
            Comandos.Add(comando);
        }
        public void Processa()
        {
            foreach (var comando in this.Comandos)
            {
                comando.Executa();
            }
        }
    }
}