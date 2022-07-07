namespace DesignPatterns2.cap9
{
    public class Facade
    {
        public Cliente BuscaCliente(string cpf)
        {
            return new ClienteDAO().BuscaPorCpf(cpf)
        }
        public Fatura CriarFatura(Cliente cliente, double valor)
        {
            return new Fatura(cliente, valor);
        }
        public Cobranca GeraCobranca(Tipo tipo, Fatura fatura)
        {
            Cobranca cobranca = new Cobranca(tipo, fatura);

        }
        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        {
            Contato contato = new ContatoCliente(cliente, cobranca)
            contato.Dispara();
            return contato;
        }
    }
}