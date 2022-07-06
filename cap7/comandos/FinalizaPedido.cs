namespace DesignPatterns2.cap7.comandos
{
    public class FinalizaPedido : IComando
    {
        private readonly Pedido pedido;

        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executa()
        {
            System.Console.WriteLine($"pedido do {pedido.Nome} finalizado");
            pedido.Finaliza();
        }
    }
}