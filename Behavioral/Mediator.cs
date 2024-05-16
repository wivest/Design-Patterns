namespace DesignPatterns.Behavioral.Mediator
{
    // interface declaration

    interface IMediator
    {
        public void Notify(Component component);
    }

    // implementation

    class Mediator : IMediator
    {
        public void Notify(Component component)
        {
            if (component.type == "concrete type")
            {
                // process
            }
        }
    }

    // class declaration

    abstract class Component
    {
        private IMediator _mediator;

        public string type;

        public Component(IMediator mediator, string type)
        {
            _mediator = mediator;
            this.type = type;
        }

        public void OnAction()
        {
            _mediator.Notify(this);
        }
    }
}
