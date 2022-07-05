namespace DesignPatterns2.cap4
{
    public class Numero : IExpressao
    {
        public int Number { get; set; }
        public Numero(int numero)
        {
            this.Number = numero;
        }

        public int Avalia()
        {
            return this.Number;
        }
    }
}