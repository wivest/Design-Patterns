namespace DesignPatterns.Creational.Prototype
{
    // interface declaration

    interface IPrototype
    {
        public IPrototype Clone();
    }

    // implementation

    class Prototype : IPrototype
    {
        public Prototype() { }

        public Prototype(Prototype p) { }

        public virtual IPrototype Clone()
        {
            return new Prototype(this);
        }
    }
}
