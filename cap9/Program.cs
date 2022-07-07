
using System.Data;
using System.Data.SqlClient;
using System.Xml.Serialization;
using DesignPatterns2.cap9;

namespace DessignPatterns2.cap9
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            string cpf = "1234";
            Facade facede = new FacadeSingleton().Instancia;
            Cliente cliente = Facade.BuscaCliente(cpf);

            var fatura = facade.CriarFatura(cliente, 5000);
            Facade.GeraCobranca(tipo.Boleto, fatura);
        }
    }
}