
// using System.Data;
// using System.Data.SqlClient;
// using DesignPatterns2.cap6;

// namespace DessignPatterns2.cap6
// {
//     public class Program
//     {
//         static async Task Main(string[] args)
//         {
//             var enviador = new EnviaPorSms();
//             var mensagem = new MensagemAdministrativa("Arilson", enviador);
//             var enviador2 = new EnviaPorEmail();
//             var mensagem2 = new MensagemCliente("Pedrinho Matador", enviador2);
//             await mensagem.Envia();
//             await mensagem2.Envia();
//         }
//     }
// }