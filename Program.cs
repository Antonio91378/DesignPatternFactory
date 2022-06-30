using DesignPatterns2.cap1;
using System.Data;
using System.Data.SqlClient;

namespace DessignPatterns2
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDbConnection conexao = new ConnectionFactory().GetConnection();
            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "Select * from tabela";
        }
    }
}