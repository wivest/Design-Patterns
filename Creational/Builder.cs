namespace DesignPatterns.Creational.Builder
{
    // interface declaration

    interface IBuilder
    {
        public void Reset();

        public void SetParameterA();

        public void SetParameterB();
    }

    // implementation

    class Builder : IBuilder
    {
        private Product _product = new Product();

        public void Reset()
        {
            _product = new Product();
        }

        public void SetParameterA() { }

        public void SetParameterB() { }

        public Product GetResult()
        {
            return _product;
        }
    }

    // class declaration

    class Product { }

    // optional
    class Director
    {
        public void MakeProduct(IBuilder builder)
        {
            builder.Reset();
            builder.SetParameterA();
            builder.SetParameterB();
        }
    }

    // access director and builder
    class Application
    {
        public void Run()
        {
            Director director = new Director();

            // type is not an interface
            // otherwise GetResult is unavailable
            Builder builder = new Builder();

            director.MakeProduct(builder);
            Product product = builder.GetResult();
        }
    }
}
