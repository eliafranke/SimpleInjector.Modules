namespace SimpleInjector.Modules
{
    public static class ContainerExtensions
    {
        public static void RegisterModule<TModule>(this Container container) where TModule : IModule, new()
        {
            var instance = new TModule();
            instance.Load(container);
        }
    }
}