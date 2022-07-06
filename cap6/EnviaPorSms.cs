namespace DesignPatterns2.cap6
{
    public class EnviaPorSms : IEnviador
    {
        public async Task Envia(IMensagem mensagem)
        {
            System.Console.WriteLine("Enviando mensagem por Sms");
            System.Console.WriteLine(mensagem.Formata());
            await Task.Delay(TimeSpan.FromMilliseconds(1000));
            System.Console.Write(".");
            await Task.Delay(TimeSpan.FromMilliseconds(1000));
            System.Console.Write(".");
            await Task.Delay(TimeSpan.FromMilliseconds(1000));
            System.Console.Write(".");
            await Task.Delay(TimeSpan.FromMilliseconds(1000));
            System.Console.WriteLine(".");
            await Task.Delay(TimeSpan.FromMilliseconds(1000));
            System.Console.WriteLine("Mensagem Enviada");
        }
    }
}