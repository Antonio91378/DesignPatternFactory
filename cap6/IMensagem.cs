namespace DesignPatterns2.cap6
{
    public interface IMensagem
    {
        IEnviador Enviador { get; set; }
        Task Envia();
        string Formata();
    }
}