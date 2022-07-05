using DesignPatterns2.cap4;

namespace DesignPatterns2.cap5
{
    public class Impressora
    {
        public void ImprimeSoma(Soma soma)
        {
            System.Console.Write("(");
            soma.Esquerda.Aceita(this);
            System.Console.Write("+");
            soma.Direita.Aceita(this);
            System.Console.Write(")");

        }
        public void ImprimeSubtracao(Subtracao subtracao)
        {
            System.Console.Write("(");
            subtracao.Esquerda.Aceita(this);
            System.Console.Write("-");
            subtracao.Direita.Aceita(this);
            System.Console.Write(")");
        }
        public void ImprimeNumero(Numero numero)
        {
            System.Console.Write(numero.Number);
        }

    }
}