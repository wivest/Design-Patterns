namespace DesignPatterns.Creational.FactoryMethod
{
    // interface declaration

    interface IItem { }

    interface IFactory
    {
        public IItem Create();
    }

    // implementation

    class ItemA : IItem { }

    class ItemB : IItem { }

    class FactoryA : IFactory
    {
        public IItem Create()
        {
            return new ItemA();
        }
    }

    class FactoryB : IFactory
    {
        public IItem Create()
        {
            return new ItemB();
        }
    }
}
