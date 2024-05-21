namespace DesignPatterns.Creational.Singleton
{
    // non thread-safe
    sealed class Singleton
    {
        private static Singleton? _instance = null;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
