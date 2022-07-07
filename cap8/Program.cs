
using System.Data;
using System.Data.SqlClient;
using System.Xml.Serialization;
using DesignPatterns2.cap8;

namespace DessignPatterns2.cap8
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var cliente = new Cliente();
            cliente.Nome = "viitor";
            cliente.Endereco = "rua bagulho";
            cliente.DataDeNascimento = DateTime.Now;

            string xml = new GeradorDeXml().GeraXml(cliente);
        }
    }
}