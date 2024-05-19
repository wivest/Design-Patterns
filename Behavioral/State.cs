namespace DesignPatterns.Behavioral.State
{
    // interface declaration

    interface IState
    {
        public Context Context { set; }

        public void Method();
    }

    // abstract class declaration

    abstract class State : IState
    {
        public Context? Context { protected get; set; }

        public abstract void Method();
    }

    // implementation

    class State1 : State
    {
        public override void Method()
        {
            Context?.SetState(new State2());
        }
    }

    class State2 : State
    {
        public override void Method()
        {
            Context?.SetState(new State1());
        }
    }

    // class declaration

    class Context
    {
        private IState _state;

        public Context(IState state)
        {
            _state = state;
            _state.Context = this;
        }

        public void SetState(IState state)
        {
            _state = state;
        }
    }
}
