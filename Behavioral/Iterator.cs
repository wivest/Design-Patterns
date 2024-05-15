namespace DesignPatterns.Behavioral.Iterator
{
    // interface declaration

    interface IIterator
    {
        public Element Next();
        public bool HasMore();
    }

    interface IIterable
    {
        public IIterator GetIterator();
    }

    // implementation

    class Iterator : IIterator
    {
        private Collection _collection;
        private Element? _current; // current state of iterator

        public Iterator(Collection collection)
        {
            _collection = collection;
        }

        public bool HasMore()
        {
            bool hasMore = false;
            // does collection have more elements
            return hasMore;
        }

        public Element Next()
        {
            Element next;
            // get next element from collection
            next = new Element();
            return next;
        }
    }

    class Collection : IIterable
    {
        public IIterator GetIterator()
        {
            return new Iterator(this);
        }
    }

    // class declaration

    class Element { }
}
