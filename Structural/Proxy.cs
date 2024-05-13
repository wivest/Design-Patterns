namespace DesignPatterns.Structural.Proxy
{
    // interface declaration

    interface IService
    {
        public void Method();
    }

    // implementation

    class Service : IService
    {
        public void Method() { }
    }

    class Proxy : IService
    {
        private IService _service;

        public Proxy(IService service)
        {
            _service = service;
        }

        public void Method()
        {
            _service.Method();
        }
    }
}
