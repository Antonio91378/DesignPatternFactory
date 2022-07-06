namespace DesignPatterns2.cap6
{
    public class MensagemCliente : IMensagem
    {
        public string Nome { get; set; }
        public IEnviador Enviador { get; set; }

        public MensagemCliente(string nome, IEnviador enviador)
        {
            this.Nome = nome;
            Enviador = enviador;
        }
        public async Task Envia()
        {
            await this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format($"mensagem para o Cliente {Nome}");
        }
    }
}