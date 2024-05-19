namespace DesignPatterns.Behavioral.TemplateMethod
{
    // abstract class declaration

    abstract class TemplateMethod
    {
        public void Template()
        {
            VirtualMethod();
            HookMethod();
            AbstractMethod();
        }

        public virtual void VirtualMethod()
        {
            // default implementation
        }

        public virtual void HookMethod()
        {
            // no defalut implementation
        }

        public abstract void AbstractMethod();
    }
}
