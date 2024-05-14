namespace DesignPatterns.Behavioral.Command
{
    // interface declaration

    interface ICommand
    {
        public void Execute();
    }

    // implementation

    class Command : ICommand
    {
        private Receiver? _receiver;

        public void Execute()
        {
            _receiver?.Method();
        }
    }

    // class declaration

    class Invoker
    {
        private ICommand _command = new Command();

        public void Invoke()
        {
            _command.Execute();
        }
    }

    class Receiver
    {
        public void Method() { }
    }
}
