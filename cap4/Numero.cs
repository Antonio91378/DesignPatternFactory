using DesignPatterns2.cap5;

namespace DesignPatterns2.cap4
{
    public class Numero : IExpressao
    {
        public double Number { get; set; }
        public Numero(double numero)
        {
            this.Number = numero;
        }

        public double Avalia()
        {
            return this.Number;
        }
        public void Aceita(Impressora impressora)
        {
            impressora.ImprimeNumero(this);
        }

    }
}