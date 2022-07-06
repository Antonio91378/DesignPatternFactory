namespace DesignPatterns2.cap7.comandos
{
    public class PagaPedido : IComando
    {
        private readonly Pedido pedido;

        public PagaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executa()
        {
            System.Console.WriteLine($"pagando pedido do {pedido.Nome}");
            pedido.Paga();
        }
    }
}