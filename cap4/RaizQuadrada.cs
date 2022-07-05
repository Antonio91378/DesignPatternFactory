namespace DesignPatterns2.cap4
{
    public class RaizQuadrada : IExpressao
    {
        public IExpressao Valor { get; set; }
        public RaizQuadrada(IExpressao valor)
        {
            this.Valor = valor;

        }



        public double Avalia()
        {
            double valor = Valor.Avalia();
            return Math.Sqrt(valor);
        }
    }
}