
// using System.Data;
// using System.Data.SqlClient;
// using DesignPatterns2.cap7;
// using DesignPatterns2.cap7.comandos;

// namespace DessignPatterns2.cap7
// {
//     public class Program
//     {
//         static async Task Main(string[] args)
//         {
//             var fila = new FilaDeTrabalho();
//             var pedido1 = new Pedido("samuelzinnho", 3000);
//             var pedido2 = new Pedido("pedrinho", 3000);
//             var pedido3 = new Pedido("toonhao", 3000);
//             fila.Adiciona(new PagaPedido(pedido1));
//             fila.Adiciona(new FinalizaPedido(pedido1));
//             fila.Adiciona(new PagaPedido(pedido2));
//             fila.Adiciona(new FinalizaPedido(pedido2));
//             fila.Adiciona(new PagaPedido(pedido3));
//             fila.Adiciona(new FinalizaPedido(pedido3));
//             fila.Processa();
//         }
//     }
// }