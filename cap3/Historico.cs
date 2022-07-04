namespace DesignPatterns2.cap3
{
    public class Historico
    {
        private List<Estado> Estados = new List<Estado>();
        public void Adiciona(Estado estado)
        {
            Estados.Add(estado);
        }
        public Estado Pega(int indice)
        {
            return Estados[indice];
        }
    }
}