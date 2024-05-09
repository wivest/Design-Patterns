namespace DesignPatterns.Structural.Adapter
{
    // interface declaration

    interface IUnformatedLogic
    {
        public void Method(int data);
    }

    // implementation

    class Adapter : IUnformatedLogic
    {
        private Service _adaptee = new Service();

        public void Method(int data)
        {
            // format conversion
            string serviceData = data.ToString();
            _adaptee.ServiceMethod(serviceData);
        }
    }

    // class declaration

    class Service
    {
        public void ServiceMethod(string data) { }
    }
}
