namespace SimpleInjector.Modules.TestApp.Library
{
    public sealed class TestAppModule : IModule
    {
        void IModule.Load(Container container)
        {
            container.Register<IMyClass, MyInternalClass>();
        }
    }
}