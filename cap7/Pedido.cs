namespace DesignPatterns2.cap7
{
    public class Pedido
    {
        public Pedido(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Status = Status.Novo;

        }
        public void Paga()
        {
            this.Status = Status.Pago;
        }
        public void Finaliza()
        {
            this.Status = Status.Entregue;
            this.DataDeFinalizacao = DateTime.Now;
        }
        public string Nome { get; set; }
        public double Valor { private get; set; }
        public DateTime DataDeFinalizacao { private get; set; }
        public Status Status { private get; set; }
    }
}