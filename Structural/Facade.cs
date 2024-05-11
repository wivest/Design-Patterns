namespace DesignPatterns.Structural.Facade
{
    // class declaration
    class Facade
    {
        public void Method()
        {
            ComplexBehaviour.ComplexMethod();
        }
    }

    class ComplexBehaviour
    {
        public static void ComplexMethod() { }
    }
}
