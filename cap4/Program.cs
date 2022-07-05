
using System.Data;
using System.Data.SqlClient;
using DesignPatterns2.cap4;
using DesignPatterns2.cap5;

namespace DessignPatterns2.cap4
{
    public class Program
    {
        static void Main(string[] args)
        {
            IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(30), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);
            // Console.WriteLine(soma.Avalia());
            var impressora = new Impressora();
            soma.Aceita(impressora);
        }
    }
}