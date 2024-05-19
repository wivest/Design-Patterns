namespace DesignPatterns.Behavioral.Visitor
{
    // interface declaration

    interface IVisitor
    {
        public void Process(ObjectA o);
        public void Process(ObjectB o);
    }

    interface IObject
    {
        public void Accept(IVisitor visitor);
    }

    // implementation

    class ObjectA : IObject
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Process(this);
        }
    }

    class ObjectB : IObject
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Process(this);
        }
    }
}
