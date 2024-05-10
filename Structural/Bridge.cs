namespace DesignPatterns.Structural.Bridge
{
    // interface declaration

    interface IImplementation
    {
        void PlatformMethod();
    }

    // implementation

    class Implementation : IImplementation
    {
        public void PlatformMethod() { }
    }

    // class declaration

    class Abstraction
    {
        private IImplementation _implementor = new Implementation();

        void Method()
        {
            _implementor.PlatformMethod();
        }
    }
}
