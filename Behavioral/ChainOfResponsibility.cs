namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    // interface declaration

    interface IRequest { }

    interface IHandler
    {
        public IHandler? nextHandler { set; }

        public void Handle(IRequest request);
    }

    // implementation

    class Handler : IHandler
    {
        public IHandler? nextHandler { private get; set; }

        public void Handle(IRequest request)
        {
            nextHandler?.Handle(request);
        }
    }
}
