
using DesignPatterns2.cap2;
using System.Data;
using System.Data.SqlClient;

namespace DessignPatterns2.cap2
{
    public class Program
    {
        static void Main(string[] args)
        {
            NotasMusicais notas = new NotasMusicais();
            var musica = new List<INota>(){
                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("fa"),
            };

            var piano = new Piano();
            piano.Toca(musica);
        }
    }
}