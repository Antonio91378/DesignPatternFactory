namespace DesignPatterns2.cap4
{
    public class Soma : IExpressao
    {
        public Soma(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public IExpressao Esquerda { get; }
        public IExpressao Direita { get; }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return  valorEsquerda+ valorDireita ;
        }
    }
}