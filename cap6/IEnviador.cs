namespace DesignPatterns2.cap6
{
    public interface IEnviador
    {
        Task Envia(IMensagem mensagem);
    }
}