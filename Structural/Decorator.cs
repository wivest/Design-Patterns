namespace DesignPatterns.Structural.Decorator
{
    // interface declaration

    interface IComponent
    {
        public void Method();
    }

    // implementation

    class Component : IComponent
    {
        public void Method() { }
    }

    class Decorator : IComponent
    {
        private IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }

        public void Method()
        {
            _component.Method();
        }
    }

    class DerivedDecorator : Decorator
    {
        public DerivedDecorator(IComponent component)
            : base(component) { }

        public new void Method()
        {
            base.Method();
            // new behaviour
        }
    }

    // class declaration

    class Program
    {
        public static void Main()
        {
            IComponent component = new Component();
            component = new DerivedDecorator(component);
        }
    }
}
