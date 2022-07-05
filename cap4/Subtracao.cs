using DesignPatterns2.cap5;

namespace DesignPatterns2.cap4
{
    public class Subtracao : IExpressao
    {
        public Subtracao(IExpressao esquerda, IExpressao direita)
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
            return valorEsquerda - valorDireita;
        }
        public void Aceita(Impressora impressora)
        {
            impressora.ImprimeSubtracao(this);
        }

    }
}