namespace DesignPatterns.Structural.Composite
{
    // interface declaration

    interface IComponent
    {
        public void Method();
    }

    // implementation

    class Leaf : IComponent
    {
        public void Method() { }
    }

    class Composite : IComponent
    {
        private List<IComponent> _children = new List<IComponent>();

        // add/remove children methods

        public void Method()
        {
            foreach (IComponent child in _children)
            {
                child.Method();
            }
        }
    }
}
