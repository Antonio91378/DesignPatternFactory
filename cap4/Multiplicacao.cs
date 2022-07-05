namespace DesignPatterns2.cap4
{
    public class Multiplicacao : IExpressao
    {
        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public IExpressao Esquerda { get; }
        public IExpressao Direita { get; }

        public double Avalia()
        {
            double valorEsquerda = Esquerda.Avalia();
            double valorDireita = Direita.Avalia();
            return valorEsquerda * valorDireita;
        }
    }
}