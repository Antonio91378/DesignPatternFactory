namespace DesignPatterns2.cap3
{
    public class Estado
    {
        public Estado(Contrato contrato)
        {
            Contrato = contrato;
        }

        public Contrato Contrato { get; private set; }
    }
}