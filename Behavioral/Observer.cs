namespace DesignPatterns.Behavioral.Observer
{
    // interface declaration

    interface ISubscriber
    {
        public void Update(Context context);
    }

    // class declaration

    class Publisher
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
