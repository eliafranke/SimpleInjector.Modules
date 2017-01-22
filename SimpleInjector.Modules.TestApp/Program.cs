using System;
using SimpleInjector.Modules.TestApp.Library;

namespace SimpleInjector.Modules.TestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            container.RegisterModule<TestAppModule>();

            var myClass = container.GetInstance<IMyClass>();
            myClass.MyMethod(Guid.NewGuid(), new Random().Next());

            Console.ReadKey();
        }
    }
}