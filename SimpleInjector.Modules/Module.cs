namespace SimpleInjector.Modules
{
    public abstract class Module : IModule
    {
        public abstract void Load(Container container);
    }
}
