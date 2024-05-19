namespace DesignPatterns.Behavioral.Strategy
{
    // interface declaration

    interface IStrategy
    {
        public void Method();
    }

    // class declaration

    class Context
    {
        public IStrategy Strategy { protected get; set; }

        public Context(IStrategy strategy)
        {
            Strategy = strategy;
        }

        public void Method()
        {
            Strategy.Method();
        }
    }
}
