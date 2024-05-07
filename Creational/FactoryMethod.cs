namespace DesignPatterns.Creational.FactoryMethod
{
    // abstract declaration

    interface IItem { }

    abstract class Factory
    {
        public abstract IItem Create();
    }

    // implementation

    class ItemA : IItem { }

    class ItemB : IItem { }

    class FactoryA : Factory
    {
        public override IItem Create()
        {
            return new ItemA();
        }
    }

    class FactoryB : Factory
    {
        public override IItem Create()
        {
            return new ItemB();
        }
    }
}
