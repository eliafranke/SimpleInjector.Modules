namespace SimpleInjector.Modules.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            container.RegisterModule<MyModule>();
        }
    }
}
