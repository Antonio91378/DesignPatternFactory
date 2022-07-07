namespace DesignPatterns2.cap9
{
    public class FacadeSingleton
    {
        private static Facade facede = new Facade();
        public Facade Instancia
        {
            get
            {
                return facede;
            }
        }
    }
}