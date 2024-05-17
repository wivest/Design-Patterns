namespace DesignPatterns.Behavioral.Memento
{
    // interface declaration

    interface IMemento
    {
        public void Restore();
    }

    interface IOriginator
    {
        public IMemento Save();
        public void SetState(State state);
    }

    // implementation

    class Memento : IMemento
    {
        private State _state;
        private IOriginator _originator;

        public Memento(State state, IOriginator originator)
        {
            _state = state;
            _originator = originator;
        }

        public void Restore()
        {
            _originator.SetState(_state);
        }
    }

    class Originator : IOriginator
    {
        private State _state = new State();

        public IMemento Save()
        {
            return new Memento(_state, this);
        }

        public void SetState(State state)
        {
            _state = state;
        }
    }

    // class declaration

    class State { }
}
