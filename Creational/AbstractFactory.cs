namespace DesignPatterns.Creational.AbstractFactory
{
    // interface declaration

    interface IItemType1 { }

    interface IItemType2 { }

    interface IAbstractFactory
    {
        public IItemType1 CreateType1();

        public IItemType2 CreateType2();
    }

    // implementation

    class SampleItemType1 : IItemType1 { }

    class SampleItemType2 : IItemType2 { }

    class SampleAbstractFactory : IAbstractFactory
    {
        public IItemType1 CreateType1()
        {
            return new SampleItemType1();
        }

        public IItemType2 CreateType2()
        {
            return new SampleItemType2();
        }
    }
}
