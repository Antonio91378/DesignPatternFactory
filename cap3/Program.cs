
// using DesignPatterns2.cap3;
// using System.Data;
// using System.Data.SqlClient;

// namespace DessignPatterns2.cap3
// {
//     public class Program
//     {
//         static void Main(string[] args)
//         {
//             var historico = new Historico();
//             var c = new Contrato(DateTime.Now, "jose", TipoContrato.Novo);
//             historico.Adiciona(c.SalvaEstado());
//             c.Avanca();
//             historico.Adiciona(c.SalvaEstado());
//             c.Avanca();
//             historico.Adiciona(c.SalvaEstado());
//             c.Avanca();
//             historico.Adiciona(c.SalvaEstado());
//             System.Console.WriteLine(c.Tipo);
//             System.Console.WriteLine(historico.Pega(0).Contrato.Tipo);
//         }
//     }
// }