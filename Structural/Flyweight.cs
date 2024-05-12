namespace DesignPatterns.Structural.Flyweight
{
    // class declaration

    class Flyweight { }

    class Context
    {
        private Flyweight _flyweight;

        public Context(Flyweight flyweight)
        {
            _flyweight = flyweight;
        }
    }

    class Logic
    {
        // field can be contained in separate factory class
        private List<Flyweight> _references = new();

        private List<Context> _objects = new();
    }
}
