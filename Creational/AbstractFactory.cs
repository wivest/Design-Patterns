namespace DesignPatterns.Creational.AbstractFactory
{
    // abstract declaration

    interface IItemType1 { }

    interface IItemType2 { }

    abstract class AbstractFactory
    {
        public abstract IItemType1 CreateType1();

        public abstract IItemType2 CreateType2();
    }

    // implementation

    class SampleItemType1 : IItemType1 { }

    class SampleItemType2 : IItemType2 { }

    class SampleAbstractFactory : AbstractFactory
    {
        public override IItemType1 CreateType1()
        {
            return new SampleItemType1();
        }

        public override IItemType2 CreateType2()
        {
            return new SampleItemType2();
        }
    }
}
