namespace DesignPatterns.Behavioral.Observer
{
    // interface declaration

    interface ISubscriber
    {
        public void Update(Context context);
    }

    interface IPublisher
    {
        public void Subscribe(ISubscriber subscriber) { }

        public void Unsubscribe(ISubscriber subscriber) { }

        public void Notify() { }
    }

    // class declaration

    class Publisher : IPublisher
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();
        private Context _context = new Context();

        public void Subscribe(ISubscriber subscriber)
        {
            if (_subscribers.Contains(subscriber))
                return;
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void Notify()
        {
            foreach (var s in _subscribers)
            {
                s.Update(_context);
            }
        }
    }

    class Context { }
}
