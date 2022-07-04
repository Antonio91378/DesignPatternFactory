namespace DesignPatterns2.cap2
{
    public class Piano
    {
        public void Toca(List<INota> musica)
        {
            foreach (var nota in musica)
            {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}